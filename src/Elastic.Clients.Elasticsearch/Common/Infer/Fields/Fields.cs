// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using Elastic.Transport;

namespace Elastic.Clients.Elasticsearch;

internal sealed class FieldsConverter : JsonConverter<Fields>
{
	public override Fields? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType == JsonTokenType.String)
		{
			Fields fields = reader.GetString();
			return fields;
		}
		else if (reader.TokenType == JsonTokenType.StartArray)
		{
			var fields = new List<Field>();
			while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
			{
				var field = JsonSerializer.Deserialize<Field>(ref reader, options);
				fields.Add(field);
			}
			return new Fields(fields);
		}

		reader.Read();
		return null;
	}

	public override void Write(Utf8JsonWriter writer, Fields value, JsonSerializerOptions options)
	{
		if (value is null)
		{
			writer.WriteNullValue();
			return;
		}

		writer.WriteStartArray();
		foreach (var field in value.ListOfFields)
		{
			JsonSerializer.Serialize(writer, field, options);
		}
		writer.WriteEndArray();
	}
}

internal sealed class FieldConverter : JsonConverter<Field>
{
	private readonly IElasticsearchClientSettings _settings;

	public FieldConverter(IElasticsearchClientSettings settings) => _settings = settings;

	public override Field? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		// TODO - Implement fully

		switch (reader.TokenType)
		{
			case JsonTokenType.Null:
				return null;

			case JsonTokenType.String:
				return new Field(reader.GetString());
		}

		reader.Read();
		return null;
	}

	public override void Write(Utf8JsonWriter writer, Field value, JsonSerializerOptions options)
	{
		if (value is null)
		{
			writer.WriteNullValue();
			return;
		}

		var fieldName = _settings.Inferrer.Field(value);

		if (string.IsNullOrEmpty(value.Format))
		{
			writer.WriteStringValue(fieldName);
		}
		else
		{
			writer.WriteStartObject();
			writer.WritePropertyName("field");
			writer.WriteStringValue(fieldName);
			writer.WritePropertyName("format");
			writer.WriteStringValue(value.Format);
			writer.WriteEndObject();
		}
	}
}

[JsonConverter(typeof(FieldsConverter))]
[DebuggerDisplay("{DebugDisplay,nq}")]
public partial class Fields : IUrlParameter, IEnumerable<Field>, IEquatable<Fields>
{
	internal readonly List<Field> ListOfFields;

	internal Fields() => ListOfFields = new List<Field>();

	internal Fields(IEnumerable<Field> fieldNames) => ListOfFields = fieldNames.ToList();

	private string DebugDisplay =>
		$"Count: {ListOfFields.Count} [" +
		string.Join(",", ListOfFields.Select((t, i) => $"({i + 1}: {t?.DebugDisplay ?? "NULL"})")) + "]";

	IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

	public IEnumerator<Field> GetEnumerator() => ListOfFields.GetEnumerator();

	public bool Equals(Fields other) => EqualsAllFields(ListOfFields, other?.ListOfFields);

	string IUrlParameter.GetString(ITransportConfiguration settings)
	{
		if (settings is not IElasticsearchClientSettings elasticsearchClientSettings)
		{
			throw new ArgumentNullException(nameof(settings),
				$"Can not resolve {nameof(Fields)} if no {nameof(IElasticsearchClientSettings)} is provided");
		}

		return string.Join(",",
			ListOfFields.Where(f => f != null).Select(f => ((IUrlParameter)f).GetString(elasticsearchClientSettings)));
	}

	public override string ToString() => DebugDisplay;

	public static implicit operator Fields(string[] fields) =>
		fields.IsEmpty() ? null : new Fields(fields.Select(f => new Field(f)));

	public static implicit operator Fields(string field) => field.IsNullOrEmptyCommaSeparatedList(out var split)
		? null
		: new Fields(split.Select(f => new Field(f)));

	public static implicit operator Fields(Expression[] fields) =>
		fields.IsEmpty() ? null : new Fields(fields.Select(f => new Field(f)));

	public static implicit operator Fields(Expression field) =>
		field == null ? null : new Fields(new[] { new Field(field) });

	public static implicit operator Fields(Field field) => field == null ? null : new Fields(new[] { field });

	public static implicit operator Fields(PropertyInfo field) =>
		field == null ? null : new Fields(new Field[] { field });

	public static implicit operator Fields(PropertyInfo[] fields) =>
		fields.IsEmpty() ? null : new Fields(fields.Select(f => new Field(f)));

	public static implicit operator Fields(Field[] fields) => fields.IsEmpty() ? null : new Fields(fields);

	public Fields And<T, TValue>(Expression<Func<T, TValue>> field, double? boost = null, string format = null)
		where T : class
	{
		ListOfFields.Add(new Field(field, boost, format));
		return this;
	}

	public Fields And(string field, double? boost = null, string format = null)
	{
		ListOfFields.Add(new Field(field, boost, format));
		return this;
	}

	public Fields And(PropertyInfo property, double? boost = null)
	{
		ListOfFields.Add(new Field(property, boost));
		return this;
	}

	public Fields And<T>(params Expression<Func<T, object>>[] fields) where T : class
	{
		ListOfFields.AddRange(fields.Select(f => new Field(f)));
		return this;
	}

	public Fields And(params string[] fields)
	{
		ListOfFields.AddRange(fields.Select(f => new Field(f)));
		return this;
	}

	public Fields And(params PropertyInfo[] properties)
	{
		ListOfFields.AddRange(properties.Select(f => new Field(f)));
		return this;
	}

	public Fields And(params Field[] fields)
	{
		ListOfFields.AddRange(fields);
		return this;
	}

	public static bool operator ==(Fields left, Fields right) => Equals(left, right);

	public static bool operator !=(Fields left, Fields right) => !Equals(left, right);

	public override bool Equals(object obj)
	{
		switch (obj)
		{
			case Fields f:
				return Equals(f);
			case string s:
				return Equals(s);
			case Field fn:
				return Equals(fn);
			case Field[] fns:
				return Equals(fns);
			case Expression e:
				return Equals(e);
			case Expression[] es:
				return Equals(es);
			default:
				return false;
		}
	}

	private static bool EqualsAllFields(IReadOnlyList<Field> thisTypes, IReadOnlyList<Field> otherTypes)
	{
		if (thisTypes == null && otherTypes == null)
			return true;
		if (thisTypes == null || otherTypes == null)
			return false;
		if (thisTypes.Count != otherTypes.Count)
			return false;

		return thisTypes.Count == otherTypes.Count && !thisTypes.Except(otherTypes).Any();
	}

	public override int GetHashCode() => ListOfFields.GetHashCode();
}

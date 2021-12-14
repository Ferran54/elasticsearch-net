// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
//
// ------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Aggregations
{
	internal sealed class TopMetricsAggregationConverter : JsonConverter<TopMetricsAggregation>
	{
		public override TopMetricsAggregation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.StartObject)
				throw new JsonException("Unexpected JSON detected.");
			reader.Read();
			var aggName = reader.GetString();
			if (aggName != "top_metrics")
				throw new JsonException("Unexpected JSON detected.");
			var agg = new TopMetricsAggregation(aggName);
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType == JsonTokenType.PropertyName)
				{
					if (reader.ValueTextEquals("metrics"))
					{
						var value = JsonSerializer.Deserialize<IEnumerable<Elastic.Clients.Elasticsearch.Aggregations.TopMetricsValue>?>(ref reader, options);
						if (value is not null)
						{
							agg.Metrics = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("size"))
					{
						var value = JsonSerializer.Deserialize<int?>(ref reader, options);
						if (value is not null)
						{
							agg.Size = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("sort"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.SortCollection?>(ref reader, options);
						if (value is not null)
						{
							agg.Sort = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("field"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Field?>(ref reader, options);
						if (value is not null)
						{
							agg.Field = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("missing"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Aggregations.Missing?>(ref reader, options);
						if (value is not null)
						{
							agg.Missing = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("script"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Script?>(ref reader, options);
						if (value is not null)
						{
							agg.Script = value;
						}

						continue;
					}
				}
			}

			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType == JsonTokenType.PropertyName)
				{
					if (reader.ValueTextEquals("meta"))
					{
						var value = JsonSerializer.Deserialize<Dictionary<string, object>>(ref reader, options);
						if (value is not null)
						{
							agg.Meta = value;
						}

						continue;
					}
				}
			}

			reader.Read();
			return agg;
		}

		public override void Write(Utf8JsonWriter writer, TopMetricsAggregation value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("top_metrics");
			writer.WriteStartObject();
			if (value.Metrics is not null)
			{
				writer.WritePropertyName("metrics");
				JsonSerializer.Serialize(writer, value.Metrics, options);
			}

			if (value.Size.HasValue)
			{
				writer.WritePropertyName("size");
				writer.WriteNumberValue(value.Size.Value);
			}

			if (value.Sort is not null)
			{
				writer.WritePropertyName("sort");
				JsonSerializer.Serialize(writer, value.Sort, options);
			}

			if (value.Field is not null)
			{
				writer.WritePropertyName("field");
				JsonSerializer.Serialize(writer, value.Field, options);
			}

			if (value.Missing is not null)
			{
				writer.WritePropertyName("missing");
				JsonSerializer.Serialize(writer, value.Missing, options);
			}

			if (value.Script is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, value.Script, options);
			}

			writer.WriteEndObject();
			if (value.Meta is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, value.Meta, options);
			}

			writer.WriteEndObject();
		}
	}

	[JsonConverter(typeof(TopMetricsAggregationConverter))]
	public partial class TopMetricsAggregation : Aggregations.MetricAggregationBase
	{
		public TopMetricsAggregation(string name, Field field) : base(name) => Field = field;
		public TopMetricsAggregation(string name) : base(name)
		{
		}

		[JsonInclude]
		[JsonPropertyName("metrics")]
		public IEnumerable<Elastic.Clients.Elasticsearch.Aggregations.TopMetricsValue>? Metrics { get; set; }

		[JsonInclude]
		[JsonPropertyName("size")]
		public int? Size { get; set; }

		[JsonInclude]
		[JsonPropertyName("sort")]
		public Elastic.Clients.Elasticsearch.SortCollection? Sort { get; set; }
	}

	public sealed partial class TopMetricsAggregationDescriptor<T> : DescriptorBase<TopMetricsAggregationDescriptor<T>>
	{
		public TopMetricsAggregationDescriptor()
		{
		}

		internal TopMetricsAggregationDescriptor(Action<TopMetricsAggregationDescriptor<T>> configure) => configure.Invoke(this);
		internal IEnumerable<Elastic.Clients.Elasticsearch.Aggregations.TopMetricsValue>? MetricsValue { get; private set; }

		internal int? SizeValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.SortCollection? SortValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Field? FieldValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Aggregations.Missing? MissingValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Script? ScriptValue { get; private set; }

		internal Dictionary<string, object>? MetaValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.SortDescriptor<T> SortDescriptor { get; private set; }

		internal Action<Elastic.Clients.Elasticsearch.SortDescriptor<T>> SortDescriptorAction { get; private set; }

		public TopMetricsAggregationDescriptor<T> Metrics(IEnumerable<Elastic.Clients.Elasticsearch.Aggregations.TopMetricsValue>? metrics) => Assign(metrics, (a, v) => a.MetricsValue = v);
		public TopMetricsAggregationDescriptor<T> Size(int? size) => Assign(size, (a, v) => a.SizeValue = v);
		public TopMetricsAggregationDescriptor<T> Sort(Elastic.Clients.Elasticsearch.SortCollection? sort)
		{
			SortDescriptor = null;
			SortDescriptorAction = null;
			return Assign(sort, (a, v) => a.SortValue = v);
		}

		public TopMetricsAggregationDescriptor<T> Sort(Elastic.Clients.Elasticsearch.SortDescriptor<T> descriptor)
		{
			SortValue = null;
			SortDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.SortDescriptor = v);
		}

		public TopMetricsAggregationDescriptor<T> Sort(Action<Elastic.Clients.Elasticsearch.SortDescriptor<T>> configure)
		{
			SortValue = null;
			SortDescriptorAction = null;
			return Assign(configure, (a, v) => a.SortDescriptorAction = v);
		}

		public TopMetricsAggregationDescriptor<T> Field(Elastic.Clients.Elasticsearch.Field? field) => Assign(field, (a, v) => a.FieldValue = v);
		public TopMetricsAggregationDescriptor<T> Field<TValue>(Expression<Func<T, TValue>> field) => Assign(field, (a, v) => a.FieldValue = v);
		public TopMetricsAggregationDescriptor<T> Missing(Elastic.Clients.Elasticsearch.Aggregations.Missing? missing) => Assign(missing, (a, v) => a.MissingValue = v);
		public TopMetricsAggregationDescriptor<T> Script(Elastic.Clients.Elasticsearch.Script? script) => Assign(script, (a, v) => a.ScriptValue = v);
		public TopMetricsAggregationDescriptor<T> Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector) => Assign(selector, (a, v) => a.MetaValue = v?.Invoke(new FluentDictionary<string, object>()));
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("top_metrics");
			writer.WriteStartObject();
			if (MetricsValue is not null)
			{
				writer.WritePropertyName("metrics");
				JsonSerializer.Serialize(writer, MetricsValue, options);
			}

			if (SizeValue.HasValue)
			{
				writer.WritePropertyName("size");
				writer.WriteNumberValue(SizeValue.Value);
			}

			if (SortDescriptor is not null)
			{
				writer.WritePropertyName("sort");
				JsonSerializer.Serialize(writer, SortDescriptor, options);
			}
			else if (SortDescriptorAction is not null)
			{
				writer.WritePropertyName("sort");
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.SortDescriptor<T>(SortDescriptorAction), options);
			}
			else if (SortValue is not null)
			{
				writer.WritePropertyName("sort");
				JsonSerializer.Serialize(writer, SortValue, options);
			}

			if (FieldValue is not null)
			{
				writer.WritePropertyName("field");
				JsonSerializer.Serialize(writer, FieldValue, options);
			}

			if (MissingValue is not null)
			{
				writer.WritePropertyName("missing");
				JsonSerializer.Serialize(writer, MissingValue, options);
			}

			if (ScriptValue is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, ScriptValue, options);
			}

			writer.WriteEndObject();
			if (MetaValue is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, MetaValue, options);
			}

			writer.WriteEndObject();
		}
	}
}
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
	internal sealed class AutoDateHistogramAggregationConverter : JsonConverter<AutoDateHistogramAggregation>
	{
		public override AutoDateHistogramAggregation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.StartObject)
				throw new JsonException("Unexpected JSON detected.");
			var agg = new AutoDateHistogramAggregation("");
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType == JsonTokenType.PropertyName)
				{
					if (reader.ValueTextEquals("buckets"))
					{
						var value = JsonSerializer.Deserialize<int?>(ref reader, options);
						if (value is not null)
						{
							agg.Buckets = value;
						}
					}

					if (reader.ValueTextEquals("field"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Field?>(ref reader, options);
						if (value is not null)
						{
							agg.Field = value;
						}
					}

					if (reader.ValueTextEquals("format"))
					{
						var value = JsonSerializer.Deserialize<string?>(ref reader, options);
						if (value is not null)
						{
							agg.Format = value;
						}
					}

					if (reader.ValueTextEquals("minimum_interval"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Aggregations.MinimumInterval?>(ref reader, options);
						if (value is not null)
						{
							agg.MinimumInterval = value;
						}
					}

					if (reader.ValueTextEquals("missing"))
					{
						var value = JsonSerializer.Deserialize<string?>(ref reader, options);
						if (value is not null)
						{
							agg.Missing = value;
						}
					}

					if (reader.ValueTextEquals("offset"))
					{
						var value = JsonSerializer.Deserialize<string?>(ref reader, options);
						if (value is not null)
						{
							agg.Offset = value;
						}
					}

					if (reader.ValueTextEquals("params"))
					{
						var value = JsonSerializer.Deserialize<Dictionary<string, object>?>(ref reader, options);
						if (value is not null)
						{
							agg.Params = value;
						}
					}

					if (reader.ValueTextEquals("script"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Script?>(ref reader, options);
						if (value is not null)
						{
							agg.Script = value;
						}
					}

					if (reader.ValueTextEquals("time_zone"))
					{
						var value = JsonSerializer.Deserialize<string?>(ref reader, options);
						if (value is not null)
						{
							agg.TimeZone = value;
						}
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
					}

					if (reader.ValueTextEquals("aggs") || reader.ValueTextEquals("aggregations"))
					{
						var value = JsonSerializer.Deserialize<AggregationDictionary>(ref reader, options);
						if (value is not null)
						{
							agg.Aggregations = value;
						}
					}
				}
			}

			reader.Read();
			return agg;
		}

		public override void Write(Utf8JsonWriter writer, AutoDateHistogramAggregation value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("auto_date_histogram");
			writer.WriteStartObject();
			if (value.Buckets.HasValue)
			{
				writer.WritePropertyName("buckets");
				writer.WriteNumberValue(value.Buckets.Value);
			}

			if (value.Field is not null)
			{
				writer.WritePropertyName("field");
				JsonSerializer.Serialize(writer, value.Field, options);
			}

			if (!string.IsNullOrEmpty(value.Format))
			{
				writer.WritePropertyName("format");
				writer.WriteStringValue(value.Format);
			}

			if (value.MinimumInterval is not null)
			{
				writer.WritePropertyName("minimum_interval");
				JsonSerializer.Serialize(writer, value.MinimumInterval, options);
			}

			if (value.Missing is not null)
			{
				writer.WritePropertyName("missing");
				JsonSerializer.Serialize(writer, value.Missing, options);
			}

			if (!string.IsNullOrEmpty(value.Offset))
			{
				writer.WritePropertyName("offset");
				writer.WriteStringValue(value.Offset);
			}

			if (value.Params is not null)
			{
				writer.WritePropertyName("params");
				JsonSerializer.Serialize(writer, value.Params, options);
			}

			if (value.Script is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, value.Script, options);
			}

			if (!string.IsNullOrEmpty(value.TimeZone))
			{
				writer.WritePropertyName("time_zone");
				writer.WriteStringValue(value.TimeZone);
			}

			writer.WriteEndObject();
			if (value.Meta is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, value.Meta, options);
			}

			if (value.Aggregations is not null)
			{
				writer.WritePropertyName("aggregations");
				JsonSerializer.Serialize(writer, value.Aggregations, options);
			}

			writer.WriteEndObject();
		}
	}

	[JsonConverter(typeof(AutoDateHistogramAggregationConverter))]
	public partial class AutoDateHistogramAggregation : Aggregations.BucketAggregationBase
	{
		public AutoDateHistogramAggregation(string name) : base(name)
		{
		}

		[JsonInclude]
		[JsonPropertyName("buckets")]
		public int? Buckets { get; set; }

		[JsonInclude]
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field? Field { get; set; }

		[JsonInclude]
		[JsonPropertyName("format")]
		public string? Format { get; set; }

		[JsonInclude]
		[JsonPropertyName("minimum_interval")]
		public Elastic.Clients.Elasticsearch.Aggregations.MinimumInterval? MinimumInterval { get; set; }

		[JsonInclude]
		[JsonPropertyName("missing")]
		public string? Missing { get; set; }

		[JsonInclude]
		[JsonPropertyName("offset")]
		public string? Offset { get; set; }

		[JsonInclude]
		[JsonPropertyName("params")]
		public Dictionary<string, object>? Params { get; set; }

		[JsonInclude]
		[JsonPropertyName("script")]
		public Elastic.Clients.Elasticsearch.Script? Script { get; set; }

		[JsonInclude]
		[JsonPropertyName("time_zone")]
		public string? TimeZone { get; set; }
	}

	public sealed partial class AutoDateHistogramAggregationDescriptor<T> : DescriptorBase<AutoDateHistogramAggregationDescriptor<T>>
	{
		public AutoDateHistogramAggregationDescriptor()
		{
		}

		internal AutoDateHistogramAggregationDescriptor(Action<AutoDateHistogramAggregationDescriptor<T>> configure) => configure.Invoke(this);
		internal int? BucketsValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Field? FieldValue { get; private set; }

		internal string? FormatValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Aggregations.MinimumInterval? MinimumIntervalValue { get; private set; }

		internal string? MissingValue { get; private set; }

		internal string? OffsetValue { get; private set; }

		internal Dictionary<string, object>? ParamsValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Script? ScriptValue { get; private set; }

		internal string? TimeZoneValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Aggregations.AggregationDictionary? AggregationsValue { get; private set; }

		internal Dictionary<string, object>? MetaValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Aggregations.AggregationContainerDescriptor<T> AggregationsDescriptor { get; private set; }

		internal Action<Elastic.Clients.Elasticsearch.Aggregations.AggregationContainerDescriptor<T>> AggregationsDescriptorAction { get; private set; }

		public AutoDateHistogramAggregationDescriptor<T> Buckets(int? buckets) => Assign(buckets, (a, v) => a.BucketsValue = v);
		public AutoDateHistogramAggregationDescriptor<T> Field(Elastic.Clients.Elasticsearch.Field? field) => Assign(field, (a, v) => a.FieldValue = v);
		public AutoDateHistogramAggregationDescriptor<T> Field<TValue>(Expression<Func<T, TValue>> field) => Assign(field, (a, v) => a.FieldValue = v);
		public AutoDateHistogramAggregationDescriptor<T> Format(string? format) => Assign(format, (a, v) => a.FormatValue = v);
		public AutoDateHistogramAggregationDescriptor<T> MinimumInterval(Elastic.Clients.Elasticsearch.Aggregations.MinimumInterval? minimumInterval) => Assign(minimumInterval, (a, v) => a.MinimumIntervalValue = v);
		public AutoDateHistogramAggregationDescriptor<T> Missing(string? missing) => Assign(missing, (a, v) => a.MissingValue = v);
		public AutoDateHistogramAggregationDescriptor<T> Offset(string? offset) => Assign(offset, (a, v) => a.OffsetValue = v);
		public AutoDateHistogramAggregationDescriptor<T> Params(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector) => Assign(selector, (a, v) => a.ParamsValue = v?.Invoke(new FluentDictionary<string, object>()));
		public AutoDateHistogramAggregationDescriptor<T> Script(Elastic.Clients.Elasticsearch.Script? script) => Assign(script, (a, v) => a.ScriptValue = v);
		public AutoDateHistogramAggregationDescriptor<T> TimeZone(string? timeZone) => Assign(timeZone, (a, v) => a.TimeZoneValue = v);
		public AutoDateHistogramAggregationDescriptor<T> Aggregations(Elastic.Clients.Elasticsearch.Aggregations.AggregationDictionary? aggregations)
		{
			AggregationsDescriptor = null;
			AggregationsDescriptorAction = null;
			return Assign(aggregations, (a, v) => a.AggregationsValue = v);
		}

		public AutoDateHistogramAggregationDescriptor<T> Aggregations(Elastic.Clients.Elasticsearch.Aggregations.AggregationContainerDescriptor<T> descriptor)
		{
			AggregationsValue = null;
			AggregationsDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.AggregationsDescriptor = v);
		}

		public AutoDateHistogramAggregationDescriptor<T> Aggregations(Action<Elastic.Clients.Elasticsearch.Aggregations.AggregationContainerDescriptor<T>> configure)
		{
			AggregationsValue = null;
			AggregationsDescriptorAction = null;
			return Assign(configure, (a, v) => a.AggregationsDescriptorAction = v);
		}

		public AutoDateHistogramAggregationDescriptor<T> Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector) => Assign(selector, (a, v) => a.MetaValue = v?.Invoke(new FluentDictionary<string, object>()));
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("auto_date_histogram");
			writer.WriteStartObject();
			if (BucketsValue.HasValue)
			{
				writer.WritePropertyName("buckets");
				writer.WriteNumberValue(BucketsValue.Value);
			}

			if (FieldValue is not null)
			{
				writer.WritePropertyName("field");
				JsonSerializer.Serialize(writer, FieldValue, options);
			}

			if (!string.IsNullOrEmpty(FormatValue))
			{
				writer.WritePropertyName("format");
				writer.WriteStringValue(FormatValue);
			}

			if (MinimumIntervalValue is not null)
			{
				writer.WritePropertyName("minimum_interval");
				JsonSerializer.Serialize(writer, MinimumIntervalValue, options);
			}

			if (MissingValue is not null)
			{
				writer.WritePropertyName("missing");
				JsonSerializer.Serialize(writer, MissingValue, options);
			}

			if (!string.IsNullOrEmpty(OffsetValue))
			{
				writer.WritePropertyName("offset");
				writer.WriteStringValue(OffsetValue);
			}

			if (ParamsValue is not null)
			{
				writer.WritePropertyName("params");
				JsonSerializer.Serialize(writer, ParamsValue, options);
			}

			if (ScriptValue is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, ScriptValue, options);
			}

			if (!string.IsNullOrEmpty(TimeZoneValue))
			{
				writer.WritePropertyName("time_zone");
				writer.WriteStringValue(TimeZoneValue);
			}

			writer.WriteEndObject();
			if (MetaValue is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, MetaValue, options);
			}

			if (AggregationsDescriptor is not null)
			{
				writer.WritePropertyName("aggregations");
				JsonSerializer.Serialize(writer, AggregationsDescriptor, options);
			}
			else if (AggregationsDescriptorAction is not null)
			{
				writer.WritePropertyName("aggregations");
				JsonSerializer.Serialize(writer, new AggregationContainerDescriptor<T>(AggregationsDescriptorAction), options);
			}
			else if (AggregationsValue is not null)
			{
				writer.WritePropertyName("aggregations");
				JsonSerializer.Serialize(writer, AggregationsValue, options);
			}

			writer.WriteEndObject();
		}
	}
}
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
namespace Elastic.Clients.Elasticsearch.QueryDsl
{
	public partial class ScriptScoreQuery : QueryDsl.QueryBase, IQueryContainerVariant
	{
		[JsonIgnore]
		string QueryDsl.IQueryContainerVariant.QueryContainerVariantName => "script_score";
		[JsonInclude]
		[JsonPropertyName("min_score")]
		public float? MinScore { get; set; }

		[JsonInclude]
		[JsonPropertyName("query")]
		public Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer Query { get; set; }

		[JsonInclude]
		[JsonPropertyName("script")]
		public Elastic.Clients.Elasticsearch.Script Script { get; set; }
	}

	public sealed partial class ScriptScoreQueryDescriptor<T> : DescriptorBase<ScriptScoreQueryDescriptor<T>>
	{
		public ScriptScoreQueryDescriptor()
		{
		}

		internal ScriptScoreQueryDescriptor(Action<ScriptScoreQueryDescriptor<T>> configure) => configure.Invoke(this);
		internal float? MinScoreValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer QueryValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Script ScriptValue { get; private set; }

		internal float? BoostValue { get; private set; }

		internal string? QueryNameValue { get; private set; }

		internal QueryContainerDescriptor<T> QueryDescriptor { get; private set; }

		internal Action<QueryContainerDescriptor<T>> QueryDescriptorAction { get; private set; }

		public ScriptScoreQueryDescriptor<T> MinScore(float? minScore) => Assign(minScore, (a, v) => a.MinScoreValue = v);
		public ScriptScoreQueryDescriptor<T> Query(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer query)
		{
			QueryDescriptor = null;
			QueryDescriptorAction = null;
			return Assign(query, (a, v) => a.QueryValue = v);
		}

		public ScriptScoreQueryDescriptor<T> Query(QueryDsl.QueryContainerDescriptor<T> descriptor)
		{
			QueryValue = null;
			QueryDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.QueryDescriptor = v);
		}

		public ScriptScoreQueryDescriptor<T> Query(Action<QueryDsl.QueryContainerDescriptor<T>> configure)
		{
			QueryValue = null;
			QueryDescriptorAction = null;
			return Assign(configure, (a, v) => a.QueryDescriptorAction = v);
		}

		public ScriptScoreQueryDescriptor<T> Script(Elastic.Clients.Elasticsearch.Script script) => Assign(script, (a, v) => a.ScriptValue = v);
		public ScriptScoreQueryDescriptor<T> Boost(float? boost) => Assign(boost, (a, v) => a.BoostValue = v);
		public ScriptScoreQueryDescriptor<T> QueryName(string? queryName) => Assign(queryName, (a, v) => a.QueryNameValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (MinScoreValue.HasValue)
			{
				writer.WritePropertyName("min_score");
				writer.WriteNumberValue(MinScoreValue.Value);
			}

			if (QueryDescriptor is not null)
			{
				writer.WritePropertyName("query");
				JsonSerializer.Serialize(writer, QueryDescriptor, options);
			}
			else if (QueryDescriptorAction is not null)
			{
				writer.WritePropertyName("query");
				JsonSerializer.Serialize(writer, new QueryDsl.QueryContainerDescriptor<T>(QueryDescriptorAction), options);
			}
			else
			{
				writer.WritePropertyName("query");
				JsonSerializer.Serialize(writer, QueryValue, options);
			}

			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptValue, options);
			if (BoostValue.HasValue)
			{
				writer.WritePropertyName("boost");
				writer.WriteNumberValue(BoostValue.Value);
			}

			if (!string.IsNullOrEmpty(QueryNameValue))
			{
				writer.WritePropertyName("_name");
				writer.WriteStringValue(QueryNameValue);
			}

			writer.WriteEndObject();
		}
	}
}
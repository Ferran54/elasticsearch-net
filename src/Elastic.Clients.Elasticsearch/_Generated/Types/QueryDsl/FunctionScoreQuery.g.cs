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
	public partial class FunctionScoreQuery : QueryDsl.QueryBase, IQueryContainerVariant
	{
		[JsonIgnore]
		string QueryDsl.IQueryContainerVariant.QueryContainerVariantName => "function_score";
		[JsonInclude]
		[JsonPropertyName("boost_mode")]
		public Elastic.Clients.Elasticsearch.QueryDsl.FunctionBoostMode? BoostMode { get; set; }

		[JsonInclude]
		[JsonPropertyName("functions")]
		public IEnumerable<Elastic.Clients.Elasticsearch.QueryDsl.FunctionScoreContainer>? Functions { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_boost")]
		public double? MaxBoost { get; set; }

		[JsonInclude]
		[JsonPropertyName("min_score")]
		public double? MinScore { get; set; }

		[JsonInclude]
		[JsonPropertyName("query")]
		public Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? Query { get; set; }

		[JsonInclude]
		[JsonPropertyName("score_mode")]
		public Elastic.Clients.Elasticsearch.QueryDsl.FunctionScoreMode? ScoreMode { get; set; }
	}

	public sealed partial class FunctionScoreQueryDescriptor<TDocument> : DescriptorBase<FunctionScoreQueryDescriptor<TDocument>>
	{
		public FunctionScoreQueryDescriptor()
		{
		}

		internal FunctionScoreQueryDescriptor(Action<FunctionScoreQueryDescriptor<TDocument>> configure) => configure.Invoke(this);
		internal Elastic.Clients.Elasticsearch.QueryDsl.FunctionBoostMode? BoostModeValue { get; private set; }

		internal IEnumerable<Elastic.Clients.Elasticsearch.QueryDsl.FunctionScoreContainer>? FunctionsValue { get; private set; }

		internal double? MaxBoostValue { get; private set; }

		internal double? MinScoreValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? QueryValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.QueryDsl.FunctionScoreMode? ScoreModeValue { get; private set; }

		internal string? QueryNameValue { get; private set; }

		internal float? BoostValue { get; private set; }

		internal QueryContainerDescriptor<TDocument> QueryDescriptor { get; private set; }

		internal Action<QueryContainerDescriptor<TDocument>> QueryDescriptorAction { get; private set; }

		public FunctionScoreQueryDescriptor<TDocument> BoostMode(Elastic.Clients.Elasticsearch.QueryDsl.FunctionBoostMode? boostMode) => Assign(boostMode, (a, v) => a.BoostModeValue = v);
		public FunctionScoreQueryDescriptor<TDocument> Functions(IEnumerable<Elastic.Clients.Elasticsearch.QueryDsl.FunctionScoreContainer>? functions) => Assign(functions, (a, v) => a.FunctionsValue = v);
		public FunctionScoreQueryDescriptor<TDocument> MaxBoost(double? maxBoost) => Assign(maxBoost, (a, v) => a.MaxBoostValue = v);
		public FunctionScoreQueryDescriptor<TDocument> MinScore(double? minScore) => Assign(minScore, (a, v) => a.MinScoreValue = v);
		public FunctionScoreQueryDescriptor<TDocument> Query(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? query)
		{
			QueryDescriptor = null;
			QueryDescriptorAction = null;
			return Assign(query, (a, v) => a.QueryValue = v);
		}

		public FunctionScoreQueryDescriptor<TDocument> Query(QueryDsl.QueryContainerDescriptor<TDocument> descriptor)
		{
			QueryValue = null;
			QueryDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.QueryDescriptor = v);
		}

		public FunctionScoreQueryDescriptor<TDocument> Query(Action<QueryDsl.QueryContainerDescriptor<TDocument>> configure)
		{
			QueryValue = null;
			QueryDescriptorAction = null;
			return Assign(configure, (a, v) => a.QueryDescriptorAction = v);
		}

		public FunctionScoreQueryDescriptor<TDocument> ScoreMode(Elastic.Clients.Elasticsearch.QueryDsl.FunctionScoreMode? scoreMode) => Assign(scoreMode, (a, v) => a.ScoreModeValue = v);
		public FunctionScoreQueryDescriptor<TDocument> QueryName(string? queryName) => Assign(queryName, (a, v) => a.QueryNameValue = v);
		public FunctionScoreQueryDescriptor<TDocument> Boost(float? boost) => Assign(boost, (a, v) => a.BoostValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (BoostModeValue is not null)
			{
				writer.WritePropertyName("boost_mode");
				JsonSerializer.Serialize(writer, BoostModeValue, options);
			}

			if (FunctionsValue is not null)
			{
				writer.WritePropertyName("functions");
				JsonSerializer.Serialize(writer, FunctionsValue, options);
			}

			if (MaxBoostValue.HasValue)
			{
				writer.WritePropertyName("max_boost");
				writer.WriteNumberValue(MaxBoostValue.Value);
			}

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
				JsonSerializer.Serialize(writer, new QueryDsl.QueryContainerDescriptor<TDocument>(QueryDescriptorAction), options);
			}
			else if (QueryValue is not null)
			{
				writer.WritePropertyName("query");
				JsonSerializer.Serialize(writer, QueryValue, options);
			}

			if (ScoreModeValue is not null)
			{
				writer.WritePropertyName("score_mode");
				JsonSerializer.Serialize(writer, ScoreModeValue, options);
			}

			if (!string.IsNullOrEmpty(QueryNameValue))
			{
				writer.WritePropertyName("_name");
				writer.WriteStringValue(QueryNameValue);
			}

			if (BoostValue.HasValue)
			{
				writer.WritePropertyName("boost");
				writer.WriteNumberValue(BoostValue.Value);
			}

			writer.WriteEndObject();
		}
	}
}
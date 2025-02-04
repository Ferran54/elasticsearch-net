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

using Elastic.Transport.Products.Elasticsearch;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch
{
	public partial class KnnSearchResponse<TDocument> : ElasticsearchResponseBase
	{
		[JsonInclude]
		[JsonPropertyName("fields")]
		public Dictionary<string, object>? Fields { get; init; }

		[JsonInclude]
		[JsonPropertyName("hits")]
		public Elastic.Clients.Elasticsearch.HitsMetadata<TDocument> Hits { get; init; }

		[JsonInclude]
		[JsonPropertyName("max_score")]
		public double? MaxScore { get; init; }

		[JsonInclude]
		[JsonPropertyName("_shards")]
		public Elastic.Clients.Elasticsearch.ShardStatistics Shards { get; init; }

		[JsonInclude]
		[JsonPropertyName("timed_out")]
		public bool TimedOut { get; init; }

		[JsonInclude]
		[JsonPropertyName("took")]
		public long Took { get; init; }
	}
}
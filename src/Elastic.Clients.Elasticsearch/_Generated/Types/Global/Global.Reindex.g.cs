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

using Elastic.Transport.Products.Elasticsearch.Failures;
using OneOf;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Global.Reindex
{
	public partial class Destination
	{
		[JsonInclude]
		[JsonPropertyName("index")]
		public Elastic.Clients.Elasticsearch.IndexName Index { get; set; }

		[JsonInclude]
		[JsonPropertyName("op_type")]
		public Elastic.Clients.Elasticsearch.OpType? OpType { get; set; }

		[JsonInclude]
		[JsonPropertyName("pipeline")]
		public string? Pipeline { get; set; }

		[JsonInclude]
		[JsonPropertyName("routing")]
		public Elastic.Clients.Elasticsearch.Routing? Routing { get; set; }

		[JsonInclude]
		[JsonPropertyName("version_type")]
		public Elastic.Clients.Elasticsearch.VersionType? VersionType { get; set; }
	}

	public partial class RemoteSource
	{
		[JsonInclude]
		[JsonPropertyName("connect_timeout")]
		public Elastic.Clients.Elasticsearch.Time ConnectTimeout { get; set; }

		[JsonInclude]
		[JsonPropertyName("host")]
		public Elastic.Clients.Elasticsearch.Host Host { get; set; }

		[JsonInclude]
		[JsonPropertyName("password")]
		public Elastic.Clients.Elasticsearch.Password Password { get; set; }

		[JsonInclude]
		[JsonPropertyName("socket_timeout")]
		public Elastic.Clients.Elasticsearch.Time SocketTimeout { get; set; }

		[JsonInclude]
		[JsonPropertyName("username")]
		public Elastic.Clients.Elasticsearch.Username Username { get; set; }
	}

	public partial class Source
	{
		[JsonInclude]
		[JsonPropertyName("index")]
		public Elastic.Clients.Elasticsearch.Indices Index { get; set; }

		[JsonInclude]
		[JsonPropertyName("query")]
		public Elastic.Clients.Elasticsearch.QueryDsl.IQueryContainer? Query { get; set; }

		[JsonInclude]
		[JsonPropertyName("remote")]
		public Elastic.Clients.Elasticsearch.Global.Reindex.RemoteSource? Remote { get; set; }

		[JsonInclude]
		[JsonPropertyName("size")]
		public int? Size { get; set; }

		[JsonInclude]
		[JsonPropertyName("slice")]
		public Elastic.Clients.Elasticsearch.SlicedScroll? Slice { get; set; }

		[JsonInclude]
		[JsonPropertyName("sort")]
		public Elastic.Clients.Elasticsearch.Global.Search.Sort? Sort { get; set; }

		[JsonInclude]
		[JsonPropertyName("_source")]
		public Elastic.Clients.Elasticsearch.Fields? source_fields { get; set; }
	}
}
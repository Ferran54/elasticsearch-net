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
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.QueryDsl
{
	[ConvertAs(typeof(HasParentQuery))]
	public partial interface IHasParentQuery : IQuery
	{
		bool? IgnoreUnmapped { get; set; }

		Elastic.Clients.Elasticsearch.Global.Search.InnerHits? InnerHits { get; set; }

		Elastic.Clients.Elasticsearch.RelationName ParentType { get; set; }

		Elastic.Clients.Elasticsearch.QueryDsl.IQueryContainer Query { get; set; }

		bool? Score { get; set; }
	}

	public partial class HasParentQuery : QueryBase, IHasParentQuery
	{
		[JsonInclude]
		[JsonPropertyName("ignore_unmapped")]
		public bool? IgnoreUnmapped { get; set; }

		[JsonInclude]
		[JsonPropertyName("inner_hits")]
		public Elastic.Clients.Elasticsearch.Global.Search.InnerHits? InnerHits { get; set; }

		[JsonInclude]
		[JsonPropertyName("parent_type")]
		public Elastic.Clients.Elasticsearch.RelationName ParentType { get; set; }

		[JsonInclude]
		[JsonPropertyName("query")]
		public Elastic.Clients.Elasticsearch.QueryDsl.IQueryContainer Query { get; set; }

		[JsonInclude]
		[JsonPropertyName("score")]
		public bool? Score { get; set; }
	}

	public partial class HasParentQueryDescriptor : QueryDescriptorBase<HasParentQueryDescriptor, IHasParentQuery>, IHasParentQuery
	{
		bool? IHasParentQuery.IgnoreUnmapped { get; set; }

		Elastic.Clients.Elasticsearch.Global.Search.InnerHits? IHasParentQuery.InnerHits { get; set; }

		Elastic.Clients.Elasticsearch.RelationName IHasParentQuery.ParentType { get; set; }

		Elastic.Clients.Elasticsearch.QueryDsl.IQueryContainer IHasParentQuery.Query { get; set; }

		bool? IHasParentQuery.Score { get; set; }
	}
}
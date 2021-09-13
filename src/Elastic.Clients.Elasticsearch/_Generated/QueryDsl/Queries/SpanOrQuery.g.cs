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
	[ConvertAs(typeof(SpanOrQuery))]
	public partial interface ISpanOrQuery : IQuery
	{
		IEnumerable<Elastic.Clients.Elasticsearch.QueryDsl.ISpanQuery> Clauses { get; set; }
	}

	public partial class SpanOrQuery : QueryBase, ISpanOrQuery
	{
		[JsonInclude]
		[JsonPropertyName("clauses")]
		public IEnumerable<Elastic.Clients.Elasticsearch.QueryDsl.ISpanQuery> Clauses { get; set; }
	}

	public partial class SpanOrQueryDescriptor : QueryDescriptorBase<SpanOrQueryDescriptor, ISpanOrQuery>, ISpanOrQuery
	{
		IEnumerable<Elastic.Clients.Elasticsearch.QueryDsl.ISpanQuery> ISpanOrQuery.Clauses { get; set; }
	}
}
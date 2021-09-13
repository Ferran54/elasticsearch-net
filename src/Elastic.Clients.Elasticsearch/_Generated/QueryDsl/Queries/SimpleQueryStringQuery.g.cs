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
	[ConvertAs(typeof(SimpleQueryStringQuery))]
	public partial interface ISimpleQueryStringQuery : IQuery
	{
		string? Analyzer { get; set; }

		bool? AnalyzeWildcard { get; set; }

		bool? AutoGenerateSynonymsPhraseQuery { get; set; }

		Elastic.Clients.Elasticsearch.QueryDsl.Operator? DefaultOperator { get; set; }

		IEnumerable<Elastic.Clients.Elasticsearch.Field>? Fields { get; set; }

		Union<Elastic.Clients.Elasticsearch.QueryDsl.SimpleQueryStringFlags, string>? Flags { get; set; }

		int? FuzzyMaxExpansions { get; set; }

		int? FuzzyPrefixLength { get; set; }

		bool? FuzzyTranspositions { get; set; }

		bool? Lenient { get; set; }

		Elastic.Clients.Elasticsearch.MinimumShouldMatch? MinimumShouldMatch { get; set; }

		string Query { get; set; }

		string? QuoteFieldSuffix { get; set; }
	}

	public partial class SimpleQueryStringQuery : QueryBase, ISimpleQueryStringQuery
	{
		[JsonInclude]
		[JsonPropertyName("analyzer")]
		public string? Analyzer { get; set; }

		[JsonInclude]
		[JsonPropertyName("analyze_wildcard")]
		public bool? AnalyzeWildcard { get; set; }

		[JsonInclude]
		[JsonPropertyName("auto_generate_synonyms_phrase_query")]
		public bool? AutoGenerateSynonymsPhraseQuery { get; set; }

		[JsonInclude]
		[JsonPropertyName("default_operator")]
		public Elastic.Clients.Elasticsearch.QueryDsl.Operator? DefaultOperator { get; set; }

		[JsonInclude]
		[JsonPropertyName("fields")]
		public IEnumerable<Elastic.Clients.Elasticsearch.Field>? Fields { get; set; }

		[JsonInclude]
		[JsonPropertyName("flags")]
		public Union<Elastic.Clients.Elasticsearch.QueryDsl.SimpleQueryStringFlags, string>? Flags { get; set; }

		[JsonInclude]
		[JsonPropertyName("fuzzy_max_expansions")]
		public int? FuzzyMaxExpansions { get; set; }

		[JsonInclude]
		[JsonPropertyName("fuzzy_prefix_length")]
		public int? FuzzyPrefixLength { get; set; }

		[JsonInclude]
		[JsonPropertyName("fuzzy_transpositions")]
		public bool? FuzzyTranspositions { get; set; }

		[JsonInclude]
		[JsonPropertyName("lenient")]
		public bool? Lenient { get; set; }

		[JsonInclude]
		[JsonPropertyName("minimum_should_match")]
		public Elastic.Clients.Elasticsearch.MinimumShouldMatch? MinimumShouldMatch { get; set; }

		[JsonInclude]
		[JsonPropertyName("query")]
		public string Query { get; set; }

		[JsonInclude]
		[JsonPropertyName("quote_field_suffix")]
		public string? QuoteFieldSuffix { get; set; }
	}

	public partial class SimpleQueryStringQueryDescriptor : QueryDescriptorBase<SimpleQueryStringQueryDescriptor, ISimpleQueryStringQuery>, ISimpleQueryStringQuery
	{
		string? ISimpleQueryStringQuery.Analyzer { get; set; }

		bool? ISimpleQueryStringQuery.AnalyzeWildcard { get; set; }

		bool? ISimpleQueryStringQuery.AutoGenerateSynonymsPhraseQuery { get; set; }

		Elastic.Clients.Elasticsearch.QueryDsl.Operator? ISimpleQueryStringQuery.DefaultOperator { get; set; }

		IEnumerable<Elastic.Clients.Elasticsearch.Field>? ISimpleQueryStringQuery.Fields { get; set; }

		Union<Elastic.Clients.Elasticsearch.QueryDsl.SimpleQueryStringFlags, string>? ISimpleQueryStringQuery.Flags { get; set; }

		int? ISimpleQueryStringQuery.FuzzyMaxExpansions { get; set; }

		int? ISimpleQueryStringQuery.FuzzyPrefixLength { get; set; }

		bool? ISimpleQueryStringQuery.FuzzyTranspositions { get; set; }

		bool? ISimpleQueryStringQuery.Lenient { get; set; }

		Elastic.Clients.Elasticsearch.MinimumShouldMatch? ISimpleQueryStringQuery.MinimumShouldMatch { get; set; }

		string ISimpleQueryStringQuery.Query { get; set; }

		string? ISimpleQueryStringQuery.QuoteFieldSuffix { get; set; }
	}
}
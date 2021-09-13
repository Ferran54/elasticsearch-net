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
	[ConvertAs(typeof(MultiMatchQuery))]
	public partial interface IMultiMatchQuery : IQuery
	{
		string? Analyzer { get; set; }

		bool? AutoGenerateSynonymsPhraseQuery { get; set; }

		double? CutoffFrequency { get; set; }

		Elastic.Clients.Elasticsearch.Fields? Fields { get; set; }

		Elastic.Clients.Elasticsearch.Fuzziness? Fuzziness { get; set; }

		Elastic.Clients.Elasticsearch.MultiTermQueryRewrite? FuzzyRewrite { get; set; }

		bool? FuzzyTranspositions { get; set; }

		bool? Lenient { get; set; }

		int? MaxExpansions { get; set; }

		Elastic.Clients.Elasticsearch.MinimumShouldMatch? MinimumShouldMatch { get; set; }

		Elastic.Clients.Elasticsearch.QueryDsl.Operator? Operator { get; set; }

		int? PrefixLength { get; set; }

		string Query { get; set; }

		int? Slop { get; set; }

		double? TieBreaker { get; set; }

		Elastic.Clients.Elasticsearch.QueryDsl.TextQueryType? Type { get; set; }

		Elastic.Clients.Elasticsearch.QueryDsl.ZeroTermsQuery? ZeroTermsQuery { get; set; }
	}

	public partial class MultiMatchQuery : QueryBase, IMultiMatchQuery
	{
		[JsonInclude]
		[JsonPropertyName("analyzer")]
		public string? Analyzer { get; set; }

		[JsonInclude]
		[JsonPropertyName("auto_generate_synonyms_phrase_query")]
		public bool? AutoGenerateSynonymsPhraseQuery { get; set; }

		[JsonInclude]
		[JsonPropertyName("cutoff_frequency")]
		public double? CutoffFrequency { get; set; }

		[JsonInclude]
		[JsonPropertyName("fields")]
		public Elastic.Clients.Elasticsearch.Fields? Fields { get; set; }

		[JsonInclude]
		[JsonPropertyName("fuzziness")]
		public Elastic.Clients.Elasticsearch.Fuzziness? Fuzziness { get; set; }

		[JsonInclude]
		[JsonPropertyName("fuzzy_rewrite")]
		public Elastic.Clients.Elasticsearch.MultiTermQueryRewrite? FuzzyRewrite { get; set; }

		[JsonInclude]
		[JsonPropertyName("fuzzy_transpositions")]
		public bool? FuzzyTranspositions { get; set; }

		[JsonInclude]
		[JsonPropertyName("lenient")]
		public bool? Lenient { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_expansions")]
		public int? MaxExpansions { get; set; }

		[JsonInclude]
		[JsonPropertyName("minimum_should_match")]
		public Elastic.Clients.Elasticsearch.MinimumShouldMatch? MinimumShouldMatch { get; set; }

		[JsonInclude]
		[JsonPropertyName("operator")]
		public Elastic.Clients.Elasticsearch.QueryDsl.Operator? Operator { get; set; }

		[JsonInclude]
		[JsonPropertyName("prefix_length")]
		public int? PrefixLength { get; set; }

		[JsonInclude]
		[JsonPropertyName("query")]
		public string Query { get; set; }

		[JsonInclude]
		[JsonPropertyName("slop")]
		public int? Slop { get; set; }

		[JsonInclude]
		[JsonPropertyName("tie_breaker")]
		public double? TieBreaker { get; set; }

		[JsonInclude]
		[JsonPropertyName("type")]
		public Elastic.Clients.Elasticsearch.QueryDsl.TextQueryType? Type { get; set; }

		[JsonInclude]
		[JsonPropertyName("zero_terms_query")]
		public Elastic.Clients.Elasticsearch.QueryDsl.ZeroTermsQuery? ZeroTermsQuery { get; set; }
	}

	public partial class MultiMatchQueryDescriptor : QueryDescriptorBase<MultiMatchQueryDescriptor, IMultiMatchQuery>, IMultiMatchQuery
	{
		string? IMultiMatchQuery.Analyzer { get; set; }

		bool? IMultiMatchQuery.AutoGenerateSynonymsPhraseQuery { get; set; }

		double? IMultiMatchQuery.CutoffFrequency { get; set; }

		Elastic.Clients.Elasticsearch.Fields? IMultiMatchQuery.Fields { get; set; }

		Elastic.Clients.Elasticsearch.Fuzziness? IMultiMatchQuery.Fuzziness { get; set; }

		Elastic.Clients.Elasticsearch.MultiTermQueryRewrite? IMultiMatchQuery.FuzzyRewrite { get; set; }

		bool? IMultiMatchQuery.FuzzyTranspositions { get; set; }

		bool? IMultiMatchQuery.Lenient { get; set; }

		int? IMultiMatchQuery.MaxExpansions { get; set; }

		Elastic.Clients.Elasticsearch.MinimumShouldMatch? IMultiMatchQuery.MinimumShouldMatch { get; set; }

		Elastic.Clients.Elasticsearch.QueryDsl.Operator? IMultiMatchQuery.Operator { get; set; }

		int? IMultiMatchQuery.PrefixLength { get; set; }

		string IMultiMatchQuery.Query { get; set; }

		int? IMultiMatchQuery.Slop { get; set; }

		double? IMultiMatchQuery.TieBreaker { get; set; }

		Elastic.Clients.Elasticsearch.QueryDsl.TextQueryType? IMultiMatchQuery.Type { get; set; }

		Elastic.Clients.Elasticsearch.QueryDsl.ZeroTermsQuery? IMultiMatchQuery.ZeroTermsQuery { get; set; }
	}
}
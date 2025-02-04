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
namespace Elastic.Clients.Elasticsearch.Analysis
{
	public abstract partial class CompoundWordTokenFilterBase : TokenFilterBase
	{
		[JsonInclude]
		[JsonPropertyName("hyphenation_patterns_path")]
		public string? HyphenationPatternsPath { get; init; }

		[JsonInclude]
		[JsonPropertyName("max_subword_size")]
		public int? MaxSubwordSize { get; init; }

		[JsonInclude]
		[JsonPropertyName("min_subword_size")]
		public int? MinSubwordSize { get; init; }

		[JsonInclude]
		[JsonPropertyName("min_word_size")]
		public int? MinWordSize { get; init; }

		[JsonInclude]
		[JsonPropertyName("only_longest_match")]
		public bool? OnlyLongestMatch { get; init; }

		[JsonInclude]
		[JsonPropertyName("word_list")]
		public IReadOnlyCollection<string>? WordList { get; init; }

		[JsonInclude]
		[JsonPropertyName("word_list_path")]
		public string? WordListPath { get; init; }
	}
}
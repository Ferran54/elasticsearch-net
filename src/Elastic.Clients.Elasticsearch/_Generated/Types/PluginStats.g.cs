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
namespace Elastic.Clients.Elasticsearch
{
	public partial class PluginStats
	{
		[JsonInclude]
		[JsonPropertyName("classname")]
		public string Classname { get; init; }

		[JsonInclude]
		[JsonPropertyName("description")]
		public string Description { get; init; }

		[JsonInclude]
		[JsonPropertyName("elasticsearch_version")]
		public string ElasticsearchVersion { get; init; }

		[JsonInclude]
		[JsonPropertyName("extended_plugins")]
		public IReadOnlyCollection<string> ExtendedPlugins { get; init; }

		[JsonInclude]
		[JsonPropertyName("has_native_controller")]
		public bool HasNativeController { get; init; }

		[JsonInclude]
		[JsonPropertyName("java_version")]
		public string JavaVersion { get; init; }

		[JsonInclude]
		[JsonPropertyName("licensed")]
		public bool Licensed { get; init; }

		[JsonInclude]
		[JsonPropertyName("name")]
		public Elastic.Clients.Elasticsearch.Name Name { get; init; }

		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type { get; init; }

		[JsonInclude]
		[JsonPropertyName("version")]
		public string Version { get; init; }
	}
}
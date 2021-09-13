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

using OneOf;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Migration
{
	public partial class DeprecationsResponse : ResponseBase
	{
		[JsonInclude]
		[JsonPropertyName("cluster_settings")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Migration.Deprecations.Deprecation> ClusterSettings
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("index_settings")]
		public Dictionary<string, IReadOnlyCollection<Elastic.Clients.Elasticsearch.Migration.Deprecations.Deprecation>> IndexSettings
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("ml_settings")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Migration.Deprecations.Deprecation> MlSettings
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("node_settings")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Migration.Deprecations.Deprecation> NodeSettings
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}
}
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
namespace Elastic.Clients.Elasticsearch.Cluster
{
	public partial class ClusterStateBlockIndex
	{
		[JsonInclude]
		[JsonPropertyName("aliases")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.IndexAlias>? Aliases
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("aliases_version")]
		public Elastic.Clients.Elasticsearch.VersionNumber? AliasesVersion
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("description")]
		public string? Description
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("in_sync_allocations")]
		public Dictionary<string, IReadOnlyCollection<string>>? InSyncAllocations
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("levels")]
		public IReadOnlyCollection<string>? Levels
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("mappings")]
		public Dictionary<string, Elastic.Clients.Elasticsearch.Mapping.TypeMapping>? Mappings
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("mapping_version")]
		public Elastic.Clients.Elasticsearch.VersionNumber? MappingVersion
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("primary_terms")]
		public Dictionary<string, int>? PrimaryTerms
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("retryable")]
		public bool? Retryable
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("rollover_info")]
		public Dictionary<string, Elastic.Clients.Elasticsearch.IndexManagement.Rollover.RolloverConditions>? RolloverInfo
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("routing_num_shards")]
		public Elastic.Clients.Elasticsearch.VersionNumber? RoutingNumShards
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("settings")]
		public Dictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.IndexSettings>? Settings
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("settings_version")]
		public Elastic.Clients.Elasticsearch.VersionNumber? SettingsVersion
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("state")]
		public string? State
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("system")]
		public bool? System
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("timestamp_range")]
		public Dictionary<string, object>? TimestampRange
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("version")]
		public Elastic.Clients.Elasticsearch.VersionNumber? Version
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ClusterStateDeletedSnapshots
	{
		[JsonInclude]
		[JsonPropertyName("snapshot_deletions")]
		public IReadOnlyCollection<string> SnapshotDeletions
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ClusterStateIndexLifecycle
	{
		[JsonInclude]
		[JsonPropertyName("operation_mode")]
		public Elastic.Clients.Elasticsearch.LifecycleOperationMode OperationMode
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("policies")]
		public Dictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.Cluster.ClusterStateIndexLifecycleSummary> Policies
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ClusterStateIndexLifecyclePolicy
	{
		[JsonInclude]
		[JsonPropertyName("phases")]
		public Elastic.Clients.Elasticsearch.Ilm.Phases Phases
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ClusterStateIndexLifecycleSummary
	{
		[JsonInclude]
		[JsonPropertyName("headers")]
		public Elastic.Clients.Elasticsearch.HttpHeaders Headers
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("modified_date")]
		public long ModifiedDate
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("modified_date_string")]
		public Elastic.Clients.Elasticsearch.DateString ModifiedDateString
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("policy")]
		public Elastic.Clients.Elasticsearch.Cluster.ClusterStateIndexLifecyclePolicy Policy
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("version")]
		public Elastic.Clients.Elasticsearch.VersionNumber Version
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ClusterStateIngest
	{
		[JsonInclude]
		[JsonPropertyName("pipeline")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Cluster.ClusterStateIngestPipeline> Pipeline
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ClusterStateIngestPipeline
	{
		[JsonInclude]
		[JsonPropertyName("config")]
		public Elastic.Clients.Elasticsearch.Cluster.ClusterStateIngestPipelineConfig Config
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("id")]
		public Elastic.Clients.Elasticsearch.Id Id
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ClusterStateIngestPipelineConfig
	{
		[JsonInclude]
		[JsonPropertyName("description")]
		public string? Description
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("processors")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer> Processors
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("version")]
		public Elastic.Clients.Elasticsearch.VersionNumber? Version
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ClusterStateMetadata
	{
		[JsonInclude]
		[JsonPropertyName("cluster_coordination")]
		public Elastic.Clients.Elasticsearch.Cluster.ClusterStateMetadataClusterCoordination ClusterCoordination
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("cluster_uuid")]
		public Elastic.Clients.Elasticsearch.Uuid ClusterUuid
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("cluster_uuid_committed")]
		public bool ClusterUuidCommitted
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("component_template")]
		public Dictionary<string, object>? ComponentTemplate
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("index-graveyard")]
		public Elastic.Clients.Elasticsearch.Cluster.ClusterStateMetadataIndexGraveyard IndexGraveyard
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("index_lifecycle")]
		public Elastic.Clients.Elasticsearch.Cluster.ClusterStateIndexLifecycle? IndexLifecycle
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("index_template")]
		public Dictionary<string, object>? IndexTemplate
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("indices")]
		public Dictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.Cluster.ClusterStateBlockIndex>? Indices
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("ingest")]
		public Elastic.Clients.Elasticsearch.Cluster.ClusterStateIngest? Ingest
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("repositories")]
		public Dictionary<string, string>? Repositories
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("templates")]
		public Elastic.Clients.Elasticsearch.Cluster.ClusterStateMetadataTemplate Templates
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ClusterStateMetadataClusterCoordination
	{
		[JsonInclude]
		[JsonPropertyName("last_accepted_config")]
		public IReadOnlyCollection<string> LastAcceptedConfig
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("last_committed_config")]
		public IReadOnlyCollection<string> LastCommittedConfig
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("term")]
		public int Term
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("voting_config_exclusions")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Cluster.VotingConfigExclusionsItem> VotingConfigExclusions
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ClusterStateMetadataIndexGraveyard
	{
		[JsonInclude]
		[JsonPropertyName("tombstones")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Cluster.Tombstone> Tombstones
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ClusterStateMetadataTemplate
	{
	}

	public partial class ClusterStateRoutingNodes
	{
		[JsonInclude]
		[JsonPropertyName("nodes")]
		public Dictionary<string, IReadOnlyCollection<Elastic.Clients.Elasticsearch.NodeShard>> Nodes
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("unassigned")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.NodeShard> Unassigned
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ClusterStateSnapshots
	{
		[JsonInclude]
		[JsonPropertyName("snapshots")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Snapshot.Status> Snapshots
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ComponentTemplate
	{
		[JsonInclude]
		[JsonPropertyName("name")]
		public Elastic.Clients.Elasticsearch.Name Name
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ComponentTemplateNode
	{
		[JsonInclude]
		[JsonPropertyName("_meta")]
		public Elastic.Clients.Elasticsearch.Metadata? Meta
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("template")]
		public Elastic.Clients.Elasticsearch.Cluster.ComponentTemplateSummary Template
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("version")]
		public Elastic.Clients.Elasticsearch.VersionNumber? Version
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ComponentTemplateSummary
	{
		[JsonInclude]
		[JsonPropertyName("aliases")]
		public Dictionary<string, Elastic.Clients.Elasticsearch.IndexManagement.AliasDefinition>? Aliases
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("mappings")]
		public Elastic.Clients.Elasticsearch.Mapping.TypeMapping? Mappings
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("_meta")]
		public Elastic.Clients.Elasticsearch.Metadata? Meta
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("settings")]
		public Dictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.IndexSettings> Settings
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("version")]
		public Elastic.Clients.Elasticsearch.VersionNumber? Version
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class Tombstone
	{
		[JsonInclude]
		[JsonPropertyName("delete_date")]
		public Elastic.Clients.Elasticsearch.DateString? DeleteDate
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("delete_date_in_millis")]
		public long DeleteDateInMillis
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("index")]
		public Elastic.Clients.Elasticsearch.Cluster.TombstoneIndex Index
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class TombstoneIndex
	{
		[JsonInclude]
		[JsonPropertyName("index_name")]
		public Elastic.Clients.Elasticsearch.Name IndexName
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("index_uuid")]
		public Elastic.Clients.Elasticsearch.Uuid IndexUuid
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class VotingConfigExclusionsItem
	{
		[JsonInclude]
		[JsonPropertyName("node_id")]
		public Elastic.Clients.Elasticsearch.Id NodeId
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("node_name")]
		public Elastic.Clients.Elasticsearch.Name NodeName
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
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
namespace Elastic.Clients.Elasticsearch.Watcher.Stats
{
	public partial class WatchRecordQueuedStats
	{
		[JsonInclude]
		[JsonPropertyName("execution_time")]
		public Elastic.Clients.Elasticsearch.DateString ExecutionTime
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class WatchRecordStats : Watcher.Stats.WatchRecordQueuedStats
	{
		[JsonInclude]
		[JsonPropertyName("executed_actions")]
		public IReadOnlyCollection<string>? ExecutedActions
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("execution_phase")]
		public Elastic.Clients.Elasticsearch.Watcher.ExecutionPhase ExecutionPhase
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("triggered_time")]
		public Elastic.Clients.Elasticsearch.DateString TriggeredTime
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("watch_id")]
		public Elastic.Clients.Elasticsearch.Id WatchId
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("watch_record_id")]
		public Elastic.Clients.Elasticsearch.Id WatchRecordId
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class WatcherNodeStats
	{
		[JsonInclude]
		[JsonPropertyName("current_watches")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Watcher.Stats.WatchRecordStats>? CurrentWatches
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("execution_thread_pool")]
		public Elastic.Clients.Elasticsearch.Watcher.ExecutionThreadPool ExecutionThreadPool
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

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
		[JsonPropertyName("queued_watches")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Watcher.Stats.WatchRecordQueuedStats>? QueuedWatches
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("watch_count")]
		public long WatchCount
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("watcher_state")]
		public Elastic.Clients.Elasticsearch.Watcher.Stats.WatcherState WatcherState
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
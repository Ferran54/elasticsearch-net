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
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Cluster.Reroute
{
	public partial class Command
	{
		[JsonInclude]
		[JsonPropertyName("cancel")]
		public Elastic.Clients.Elasticsearch.Cluster.Reroute.CommandCancelAction? Cancel { get; set; }

		[JsonInclude]
		[JsonPropertyName("move")]
		public Elastic.Clients.Elasticsearch.Cluster.Reroute.CommandMoveAction? Move { get; set; }

		[JsonInclude]
		[JsonPropertyName("allocate_replica")]
		public Elastic.Clients.Elasticsearch.Cluster.Reroute.CommandAllocateReplicaAction? AllocateReplica { get; set; }

		[JsonInclude]
		[JsonPropertyName("allocate_stale_primary")]
		public Elastic.Clients.Elasticsearch.Cluster.Reroute.CommandAllocatePrimaryAction? AllocateStalePrimary { get; set; }

		[JsonInclude]
		[JsonPropertyName("allocate_empty_primary")]
		public Elastic.Clients.Elasticsearch.Cluster.Reroute.CommandAllocatePrimaryAction? AllocateEmptyPrimary { get; set; }
	}

	public sealed partial class CommandDescriptor : DescriptorBase<CommandDescriptor>
	{
		public CommandDescriptor()
		{
		}

		internal CommandDescriptor(Action<CommandDescriptor> configure) => configure.Invoke(this);
		internal Elastic.Clients.Elasticsearch.Cluster.Reroute.CommandCancelAction? CancelValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Cluster.Reroute.CommandMoveAction? MoveValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Cluster.Reroute.CommandAllocateReplicaAction? AllocateReplicaValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Cluster.Reroute.CommandAllocatePrimaryAction? AllocateStalePrimaryValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Cluster.Reroute.CommandAllocatePrimaryAction? AllocateEmptyPrimaryValue { get; private set; }

		internal CommandCancelActionDescriptor CancelDescriptor { get; private set; }

		internal CommandMoveActionDescriptor MoveDescriptor { get; private set; }

		internal CommandAllocateReplicaActionDescriptor AllocateReplicaDescriptor { get; private set; }

		internal CommandAllocatePrimaryActionDescriptor AllocateStalePrimaryDescriptor { get; private set; }

		internal CommandAllocatePrimaryActionDescriptor AllocateEmptyPrimaryDescriptor { get; private set; }

		internal Action<CommandCancelActionDescriptor> CancelDescriptorAction { get; private set; }

		internal Action<CommandMoveActionDescriptor> MoveDescriptorAction { get; private set; }

		internal Action<CommandAllocateReplicaActionDescriptor> AllocateReplicaDescriptorAction { get; private set; }

		internal Action<CommandAllocatePrimaryActionDescriptor> AllocateStalePrimaryDescriptorAction { get; private set; }

		internal Action<CommandAllocatePrimaryActionDescriptor> AllocateEmptyPrimaryDescriptorAction { get; private set; }

		public CommandDescriptor Cancel(Elastic.Clients.Elasticsearch.Cluster.Reroute.CommandCancelAction? cancel)
		{
			CancelDescriptor = null;
			CancelDescriptorAction = null;
			return Assign(cancel, (a, v) => a.CancelValue = v);
		}

		public CommandDescriptor Cancel(Elastic.Clients.Elasticsearch.Cluster.Reroute.CommandCancelActionDescriptor descriptor)
		{
			CancelValue = null;
			CancelDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.CancelDescriptor = v);
		}

		public CommandDescriptor Cancel(Action<Elastic.Clients.Elasticsearch.Cluster.Reroute.CommandCancelActionDescriptor> configure)
		{
			CancelValue = null;
			CancelDescriptorAction = null;
			return Assign(configure, (a, v) => a.CancelDescriptorAction = v);
		}

		public CommandDescriptor Move(Elastic.Clients.Elasticsearch.Cluster.Reroute.CommandMoveAction? move)
		{
			MoveDescriptor = null;
			MoveDescriptorAction = null;
			return Assign(move, (a, v) => a.MoveValue = v);
		}

		public CommandDescriptor Move(Elastic.Clients.Elasticsearch.Cluster.Reroute.CommandMoveActionDescriptor descriptor)
		{
			MoveValue = null;
			MoveDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.MoveDescriptor = v);
		}

		public CommandDescriptor Move(Action<Elastic.Clients.Elasticsearch.Cluster.Reroute.CommandMoveActionDescriptor> configure)
		{
			MoveValue = null;
			MoveDescriptorAction = null;
			return Assign(configure, (a, v) => a.MoveDescriptorAction = v);
		}

		public CommandDescriptor AllocateReplica(Elastic.Clients.Elasticsearch.Cluster.Reroute.CommandAllocateReplicaAction? allocateReplica)
		{
			AllocateReplicaDescriptor = null;
			AllocateReplicaDescriptorAction = null;
			return Assign(allocateReplica, (a, v) => a.AllocateReplicaValue = v);
		}

		public CommandDescriptor AllocateReplica(Elastic.Clients.Elasticsearch.Cluster.Reroute.CommandAllocateReplicaActionDescriptor descriptor)
		{
			AllocateReplicaValue = null;
			AllocateReplicaDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.AllocateReplicaDescriptor = v);
		}

		public CommandDescriptor AllocateReplica(Action<Elastic.Clients.Elasticsearch.Cluster.Reroute.CommandAllocateReplicaActionDescriptor> configure)
		{
			AllocateReplicaValue = null;
			AllocateReplicaDescriptorAction = null;
			return Assign(configure, (a, v) => a.AllocateReplicaDescriptorAction = v);
		}

		public CommandDescriptor AllocateStalePrimary(Elastic.Clients.Elasticsearch.Cluster.Reroute.CommandAllocatePrimaryAction? allocateStalePrimary)
		{
			AllocateStalePrimaryDescriptor = null;
			AllocateStalePrimaryDescriptorAction = null;
			return Assign(allocateStalePrimary, (a, v) => a.AllocateStalePrimaryValue = v);
		}

		public CommandDescriptor AllocateStalePrimary(Elastic.Clients.Elasticsearch.Cluster.Reroute.CommandAllocatePrimaryActionDescriptor descriptor)
		{
			AllocateStalePrimaryValue = null;
			AllocateStalePrimaryDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.AllocateStalePrimaryDescriptor = v);
		}

		public CommandDescriptor AllocateStalePrimary(Action<Elastic.Clients.Elasticsearch.Cluster.Reroute.CommandAllocatePrimaryActionDescriptor> configure)
		{
			AllocateStalePrimaryValue = null;
			AllocateStalePrimaryDescriptorAction = null;
			return Assign(configure, (a, v) => a.AllocateStalePrimaryDescriptorAction = v);
		}

		public CommandDescriptor AllocateEmptyPrimary(Elastic.Clients.Elasticsearch.Cluster.Reroute.CommandAllocatePrimaryAction? allocateEmptyPrimary)
		{
			AllocateEmptyPrimaryDescriptor = null;
			AllocateEmptyPrimaryDescriptorAction = null;
			return Assign(allocateEmptyPrimary, (a, v) => a.AllocateEmptyPrimaryValue = v);
		}

		public CommandDescriptor AllocateEmptyPrimary(Elastic.Clients.Elasticsearch.Cluster.Reroute.CommandAllocatePrimaryActionDescriptor descriptor)
		{
			AllocateEmptyPrimaryValue = null;
			AllocateEmptyPrimaryDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.AllocateEmptyPrimaryDescriptor = v);
		}

		public CommandDescriptor AllocateEmptyPrimary(Action<Elastic.Clients.Elasticsearch.Cluster.Reroute.CommandAllocatePrimaryActionDescriptor> configure)
		{
			AllocateEmptyPrimaryValue = null;
			AllocateEmptyPrimaryDescriptorAction = null;
			return Assign(configure, (a, v) => a.AllocateEmptyPrimaryDescriptorAction = v);
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (CancelDescriptor is not null)
			{
				writer.WritePropertyName("cancel");
				JsonSerializer.Serialize(writer, CancelDescriptor, options);
			}
			else if (CancelDescriptorAction is not null)
			{
				writer.WritePropertyName("cancel");
				JsonSerializer.Serialize(writer, new CommandCancelActionDescriptor(CancelDescriptorAction), options);
			}
			else if (CancelValue is not null)
			{
				writer.WritePropertyName("cancel");
				JsonSerializer.Serialize(writer, CancelValue, options);
			}

			if (MoveDescriptor is not null)
			{
				writer.WritePropertyName("move");
				JsonSerializer.Serialize(writer, MoveDescriptor, options);
			}
			else if (MoveDescriptorAction is not null)
			{
				writer.WritePropertyName("move");
				JsonSerializer.Serialize(writer, new CommandMoveActionDescriptor(MoveDescriptorAction), options);
			}
			else if (MoveValue is not null)
			{
				writer.WritePropertyName("move");
				JsonSerializer.Serialize(writer, MoveValue, options);
			}

			if (AllocateReplicaDescriptor is not null)
			{
				writer.WritePropertyName("allocate_replica");
				JsonSerializer.Serialize(writer, AllocateReplicaDescriptor, options);
			}
			else if (AllocateReplicaDescriptorAction is not null)
			{
				writer.WritePropertyName("allocate_replica");
				JsonSerializer.Serialize(writer, new CommandAllocateReplicaActionDescriptor(AllocateReplicaDescriptorAction), options);
			}
			else if (AllocateReplicaValue is not null)
			{
				writer.WritePropertyName("allocate_replica");
				JsonSerializer.Serialize(writer, AllocateReplicaValue, options);
			}

			if (AllocateStalePrimaryDescriptor is not null)
			{
				writer.WritePropertyName("allocate_stale_primary");
				JsonSerializer.Serialize(writer, AllocateStalePrimaryDescriptor, options);
			}
			else if (AllocateStalePrimaryDescriptorAction is not null)
			{
				writer.WritePropertyName("allocate_stale_primary");
				JsonSerializer.Serialize(writer, new CommandAllocatePrimaryActionDescriptor(AllocateStalePrimaryDescriptorAction), options);
			}
			else if (AllocateStalePrimaryValue is not null)
			{
				writer.WritePropertyName("allocate_stale_primary");
				JsonSerializer.Serialize(writer, AllocateStalePrimaryValue, options);
			}

			if (AllocateEmptyPrimaryDescriptor is not null)
			{
				writer.WritePropertyName("allocate_empty_primary");
				JsonSerializer.Serialize(writer, AllocateEmptyPrimaryDescriptor, options);
			}
			else if (AllocateEmptyPrimaryDescriptorAction is not null)
			{
				writer.WritePropertyName("allocate_empty_primary");
				JsonSerializer.Serialize(writer, new CommandAllocatePrimaryActionDescriptor(AllocateEmptyPrimaryDescriptorAction), options);
			}
			else if (AllocateEmptyPrimaryValue is not null)
			{
				writer.WritePropertyName("allocate_empty_primary");
				JsonSerializer.Serialize(writer, AllocateEmptyPrimaryValue, options);
			}

			writer.WriteEndObject();
		}
	}

	public partial class CommandAllocatePrimaryAction
	{
		[JsonInclude]
		[JsonPropertyName("index")]
		public Elastic.Clients.Elasticsearch.IndexName Index { get; set; }

		[JsonInclude]
		[JsonPropertyName("shard")]
		public int Shard { get; set; }

		[JsonInclude]
		[JsonPropertyName("node")]
		public string Node { get; set; }

		[JsonInclude]
		[JsonPropertyName("accept_data_loss")]
		public bool AcceptDataLoss { get; set; }
	}

	public sealed partial class CommandAllocatePrimaryActionDescriptor : DescriptorBase<CommandAllocatePrimaryActionDescriptor>
	{
		public CommandAllocatePrimaryActionDescriptor()
		{
		}

		internal CommandAllocatePrimaryActionDescriptor(Action<CommandAllocatePrimaryActionDescriptor> configure) => configure.Invoke(this);
		internal Elastic.Clients.Elasticsearch.IndexName IndexValue { get; private set; }

		internal int ShardValue { get; private set; }

		internal string NodeValue { get; private set; }

		internal bool AcceptDataLossValue { get; private set; }

		public CommandAllocatePrimaryActionDescriptor Index(Elastic.Clients.Elasticsearch.IndexName index) => Assign(index, (a, v) => a.IndexValue = v);
		public CommandAllocatePrimaryActionDescriptor Shard(int shard) => Assign(shard, (a, v) => a.ShardValue = v);
		public CommandAllocatePrimaryActionDescriptor Node(string node) => Assign(node, (a, v) => a.NodeValue = v);
		public CommandAllocatePrimaryActionDescriptor AcceptDataLoss(bool acceptDataLoss = true) => Assign(acceptDataLoss, (a, v) => a.AcceptDataLossValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("index");
			JsonSerializer.Serialize(writer, IndexValue, options);
			writer.WritePropertyName("shard");
			writer.WriteNumberValue(ShardValue);
			writer.WritePropertyName("node");
			writer.WriteStringValue(NodeValue);
			writer.WritePropertyName("accept_data_loss");
			writer.WriteBooleanValue(AcceptDataLossValue);
			writer.WriteEndObject();
		}
	}

	public partial class CommandAllocateReplicaAction
	{
		[JsonInclude]
		[JsonPropertyName("index")]
		public Elastic.Clients.Elasticsearch.IndexName Index { get; set; }

		[JsonInclude]
		[JsonPropertyName("shard")]
		public int Shard { get; set; }

		[JsonInclude]
		[JsonPropertyName("node")]
		public string Node { get; set; }
	}

	public sealed partial class CommandAllocateReplicaActionDescriptor : DescriptorBase<CommandAllocateReplicaActionDescriptor>
	{
		public CommandAllocateReplicaActionDescriptor()
		{
		}

		internal CommandAllocateReplicaActionDescriptor(Action<CommandAllocateReplicaActionDescriptor> configure) => configure.Invoke(this);
		internal Elastic.Clients.Elasticsearch.IndexName IndexValue { get; private set; }

		internal int ShardValue { get; private set; }

		internal string NodeValue { get; private set; }

		public CommandAllocateReplicaActionDescriptor Index(Elastic.Clients.Elasticsearch.IndexName index) => Assign(index, (a, v) => a.IndexValue = v);
		public CommandAllocateReplicaActionDescriptor Shard(int shard) => Assign(shard, (a, v) => a.ShardValue = v);
		public CommandAllocateReplicaActionDescriptor Node(string node) => Assign(node, (a, v) => a.NodeValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("index");
			JsonSerializer.Serialize(writer, IndexValue, options);
			writer.WritePropertyName("shard");
			writer.WriteNumberValue(ShardValue);
			writer.WritePropertyName("node");
			writer.WriteStringValue(NodeValue);
			writer.WriteEndObject();
		}
	}

	public partial class CommandCancelAction
	{
		[JsonInclude]
		[JsonPropertyName("index")]
		public Elastic.Clients.Elasticsearch.IndexName Index { get; set; }

		[JsonInclude]
		[JsonPropertyName("shard")]
		public int Shard { get; set; }

		[JsonInclude]
		[JsonPropertyName("node")]
		public string Node { get; set; }

		[JsonInclude]
		[JsonPropertyName("allow_primary")]
		public bool? AllowPrimary { get; set; }
	}

	public sealed partial class CommandCancelActionDescriptor : DescriptorBase<CommandCancelActionDescriptor>
	{
		public CommandCancelActionDescriptor()
		{
		}

		internal CommandCancelActionDescriptor(Action<CommandCancelActionDescriptor> configure) => configure.Invoke(this);
		internal Elastic.Clients.Elasticsearch.IndexName IndexValue { get; private set; }

		internal int ShardValue { get; private set; }

		internal string NodeValue { get; private set; }

		internal bool? AllowPrimaryValue { get; private set; }

		public CommandCancelActionDescriptor Index(Elastic.Clients.Elasticsearch.IndexName index) => Assign(index, (a, v) => a.IndexValue = v);
		public CommandCancelActionDescriptor Shard(int shard) => Assign(shard, (a, v) => a.ShardValue = v);
		public CommandCancelActionDescriptor Node(string node) => Assign(node, (a, v) => a.NodeValue = v);
		public CommandCancelActionDescriptor AllowPrimary(bool? allowPrimary = true) => Assign(allowPrimary, (a, v) => a.AllowPrimaryValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("index");
			JsonSerializer.Serialize(writer, IndexValue, options);
			writer.WritePropertyName("shard");
			writer.WriteNumberValue(ShardValue);
			writer.WritePropertyName("node");
			writer.WriteStringValue(NodeValue);
			if (AllowPrimaryValue.HasValue)
			{
				writer.WritePropertyName("allow_primary");
				writer.WriteBooleanValue(AllowPrimaryValue.Value);
			}

			writer.WriteEndObject();
		}
	}

	public partial class CommandMoveAction
	{
		[JsonInclude]
		[JsonPropertyName("index")]
		public Elastic.Clients.Elasticsearch.IndexName Index { get; set; }

		[JsonInclude]
		[JsonPropertyName("shard")]
		public int Shard { get; set; }

		[JsonInclude]
		[JsonPropertyName("from_node")]
		public string FromNode { get; set; }

		[JsonInclude]
		[JsonPropertyName("to_node")]
		public string ToNode { get; set; }
	}

	public sealed partial class CommandMoveActionDescriptor : DescriptorBase<CommandMoveActionDescriptor>
	{
		public CommandMoveActionDescriptor()
		{
		}

		internal CommandMoveActionDescriptor(Action<CommandMoveActionDescriptor> configure) => configure.Invoke(this);
		internal Elastic.Clients.Elasticsearch.IndexName IndexValue { get; private set; }

		internal int ShardValue { get; private set; }

		internal string FromNodeValue { get; private set; }

		internal string ToNodeValue { get; private set; }

		public CommandMoveActionDescriptor Index(Elastic.Clients.Elasticsearch.IndexName index) => Assign(index, (a, v) => a.IndexValue = v);
		public CommandMoveActionDescriptor Shard(int shard) => Assign(shard, (a, v) => a.ShardValue = v);
		public CommandMoveActionDescriptor FromNode(string fromNode) => Assign(fromNode, (a, v) => a.FromNodeValue = v);
		public CommandMoveActionDescriptor ToNode(string toNode) => Assign(toNode, (a, v) => a.ToNodeValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("index");
			JsonSerializer.Serialize(writer, IndexValue, options);
			writer.WritePropertyName("shard");
			writer.WriteNumberValue(ShardValue);
			writer.WritePropertyName("from_node");
			writer.WriteStringValue(FromNodeValue);
			writer.WritePropertyName("to_node");
			writer.WriteStringValue(ToNodeValue);
			writer.WriteEndObject();
		}
	}

	public partial class RerouteDecision
	{
		[JsonInclude]
		[JsonPropertyName("decider")]
		public string Decider { get; init; }

		[JsonInclude]
		[JsonPropertyName("decision")]
		public string Decision { get; init; }

		[JsonInclude]
		[JsonPropertyName("explanation")]
		public string Explanation { get; init; }
	}

	public partial class RerouteExplanation
	{
		[JsonInclude]
		[JsonPropertyName("command")]
		public string Command { get; init; }

		[JsonInclude]
		[JsonPropertyName("decisions")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Cluster.Reroute.RerouteDecision> Decisions { get; init; }

		[JsonInclude]
		[JsonPropertyName("parameters")]
		public Elastic.Clients.Elasticsearch.Cluster.Reroute.RerouteParameters Parameters { get; init; }
	}

	public partial class RerouteParameters
	{
		[JsonInclude]
		[JsonPropertyName("allow_primary")]
		public bool AllowPrimary { get; init; }

		[JsonInclude]
		[JsonPropertyName("index")]
		public Elastic.Clients.Elasticsearch.IndexName Index { get; init; }

		[JsonInclude]
		[JsonPropertyName("node")]
		public string Node { get; init; }

		[JsonInclude]
		[JsonPropertyName("shard")]
		public int Shard { get; init; }

		[JsonInclude]
		[JsonPropertyName("from_node")]
		public string? FromNode { get; init; }

		[JsonInclude]
		[JsonPropertyName("to_node")]
		public string? ToNode { get; init; }
	}
}
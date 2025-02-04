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
using System.Threading;
using System.Threading.Tasks;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Cluster
{
	public class ClusterNamespace : NamespacedClientProxy
	{
		internal ClusterNamespace(ElasticsearchClient client) : base(client)
		{
		}

		public ClusterAllocationExplainResponse AllocationExplain(ClusterAllocationExplainRequest request)
		{
			request.BeforeRequest();
			return DoRequest<ClusterAllocationExplainRequest, ClusterAllocationExplainResponse>(request);
		}

		public Task<ClusterAllocationExplainResponse> AllocationExplainAsync(ClusterAllocationExplainRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<ClusterAllocationExplainRequest, ClusterAllocationExplainResponse>(request, cancellationToken);
		}

		public ClusterAllocationExplainResponse AllocationExplain(Action<ClusterAllocationExplainRequestDescriptor> configureRequest = null)
		{
			var descriptor = new ClusterAllocationExplainRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<ClusterAllocationExplainRequestDescriptor, ClusterAllocationExplainResponse>(descriptor);
		}

		public Task<ClusterAllocationExplainResponse> AllocationExplainAsync(Action<ClusterAllocationExplainRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new ClusterAllocationExplainRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<ClusterAllocationExplainRequestDescriptor, ClusterAllocationExplainResponse>(descriptor);
		}

		public ClusterHealthResponse Health(ClusterHealthRequest request)
		{
			request.BeforeRequest();
			return DoRequest<ClusterHealthRequest, ClusterHealthResponse>(request);
		}

		public Task<ClusterHealthResponse> HealthAsync(ClusterHealthRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<ClusterHealthRequest, ClusterHealthResponse>(request, cancellationToken);
		}

		public ClusterHealthResponse Health(Action<ClusterHealthRequestDescriptor> configureRequest = null)
		{
			var descriptor = new ClusterHealthRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<ClusterHealthRequestDescriptor, ClusterHealthResponse>(descriptor);
		}

		public Task<ClusterHealthResponse> HealthAsync(Action<ClusterHealthRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new ClusterHealthRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<ClusterHealthRequestDescriptor, ClusterHealthResponse>(descriptor);
		}

		public ClusterPendingTasksResponse PendingTasks(ClusterPendingTasksRequest request)
		{
			request.BeforeRequest();
			return DoRequest<ClusterPendingTasksRequest, ClusterPendingTasksResponse>(request);
		}

		public Task<ClusterPendingTasksResponse> PendingTasksAsync(ClusterPendingTasksRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<ClusterPendingTasksRequest, ClusterPendingTasksResponse>(request, cancellationToken);
		}

		public ClusterPendingTasksResponse PendingTasks(Action<ClusterPendingTasksRequestDescriptor> configureRequest = null)
		{
			var descriptor = new ClusterPendingTasksRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<ClusterPendingTasksRequestDescriptor, ClusterPendingTasksResponse>(descriptor);
		}

		public Task<ClusterPendingTasksResponse> PendingTasksAsync(Action<ClusterPendingTasksRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new ClusterPendingTasksRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<ClusterPendingTasksRequestDescriptor, ClusterPendingTasksResponse>(descriptor);
		}

		public ClusterStateResponse State(ClusterStateRequest request)
		{
			request.BeforeRequest();
			return DoRequest<ClusterStateRequest, ClusterStateResponse>(request);
		}

		public Task<ClusterStateResponse> StateAsync(ClusterStateRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<ClusterStateRequest, ClusterStateResponse>(request, cancellationToken);
		}

		public ClusterStateResponse State(Action<ClusterStateRequestDescriptor> configureRequest = null)
		{
			var descriptor = new ClusterStateRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<ClusterStateRequestDescriptor, ClusterStateResponse>(descriptor);
		}

		public Task<ClusterStateResponse> StateAsync(Action<ClusterStateRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new ClusterStateRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<ClusterStateRequestDescriptor, ClusterStateResponse>(descriptor);
		}
	}
}
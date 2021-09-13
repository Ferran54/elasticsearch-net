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

using Elastic.Transport;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Ccr
{
	[ConvertAs(typeof(DeleteAutoFollowPatternRequest))]
	public partial interface IDeleteAutoFollowPatternRequest : IRequest<DeleteAutoFollowPatternRequestParameters>
	{
	}

	public partial class DeleteAutoFollowPatternRequest : PlainRequestBase<DeleteAutoFollowPatternRequestParameters>, IDeleteAutoFollowPatternRequest
	{
		protected IDeleteAutoFollowPatternRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CrossClusterReplicationDeleteAutoFollowPattern;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => false;
		protected override bool IsEmpty => false;

		///<summary>/_ccr/auto_follow/{name}</summary>
        public DeleteAutoFollowPatternRequest(Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("name", name))
		{
		}
	}

	[ConvertAs(typeof(FollowRequest))]
	public partial interface IFollowRequest : IRequest<FollowRequestParameters>
	{
		Elastic.Clients.Elasticsearch.IndexName? LeaderIndex { get; set; }

		long? MaxOutstandingReadRequests { get; set; }

		long? MaxOutstandingWriteRequests { get; set; }

		long? MaxReadRequestOperationCount { get; set; }

		string? MaxReadRequestSize { get; set; }

		Elastic.Clients.Elasticsearch.Time? MaxRetryDelay { get; set; }

		long? MaxWriteBufferCount { get; set; }

		string? MaxWriteBufferSize { get; set; }

		long? MaxWriteRequestOperationCount { get; set; }

		string? MaxWriteRequestSize { get; set; }

		Elastic.Clients.Elasticsearch.Time? ReadPollTimeout { get; set; }

		string? RemoteCluster { get; set; }
	}

	public partial class FollowRequest : PlainRequestBase<FollowRequestParameters>, IFollowRequest
	{
		protected IFollowRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CrossClusterReplicationFollow;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => true;
		protected override bool CanBeEmpty => false;
		protected override bool IsEmpty => false;

		///<summary>/{index}/_ccr/follow</summary>
        public FollowRequest(Elastic.Clients.Elasticsearch.IndexName index) : base(r => r.Required("index", index))
		{
		}

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.WaitForActiveShards? WaitForActiveShards { get => Q<Elastic.Clients.Elasticsearch.WaitForActiveShards?>("wait_for_active_shards"); set => Q("wait_for_active_shards", value); }

		[JsonInclude]
		[JsonPropertyName("leader_index")]
		public Elastic.Clients.Elasticsearch.IndexName? LeaderIndex { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_outstanding_read_requests")]
		public long? MaxOutstandingReadRequests { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_outstanding_write_requests")]
		public long? MaxOutstandingWriteRequests { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_read_request_operation_count")]
		public long? MaxReadRequestOperationCount { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_read_request_size")]
		public string? MaxReadRequestSize { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_retry_delay")]
		public Elastic.Clients.Elasticsearch.Time? MaxRetryDelay { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_write_buffer_count")]
		public long? MaxWriteBufferCount { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_write_buffer_size")]
		public string? MaxWriteBufferSize { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_write_request_operation_count")]
		public long? MaxWriteRequestOperationCount { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_write_request_size")]
		public string? MaxWriteRequestSize { get; set; }

		[JsonInclude]
		[JsonPropertyName("read_poll_timeout")]
		public Elastic.Clients.Elasticsearch.Time? ReadPollTimeout { get; set; }

		[JsonInclude]
		[JsonPropertyName("remote_cluster")]
		public string? RemoteCluster { get; set; }
	}

	[ConvertAs(typeof(FollowInfoRequest))]
	public partial interface IFollowInfoRequest : IRequest<FollowInfoRequestParameters>
	{
	}

	public partial class FollowInfoRequest : PlainRequestBase<FollowInfoRequestParameters>, IFollowInfoRequest
	{
		protected IFollowInfoRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CrossClusterReplicationFollowInfo;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => false;
		protected override bool IsEmpty => false;

		///<summary>/{index}/_ccr/info</summary>
        public FollowInfoRequest(Elastic.Clients.Elasticsearch.Indices index) : base(r => r.Required("index", index))
		{
		}
	}

	[ConvertAs(typeof(FollowStatsRequest))]
	public partial interface IFollowStatsRequest : IRequest<FollowStatsRequestParameters>
	{
	}

	public partial class FollowStatsRequest : PlainRequestBase<FollowStatsRequestParameters>, IFollowStatsRequest
	{
		protected IFollowStatsRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CrossClusterReplicationFollowStats;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => false;
		protected override bool IsEmpty => false;

		///<summary>/{index}/_ccr/stats</summary>
        public FollowStatsRequest(Elastic.Clients.Elasticsearch.Indices index) : base(r => r.Required("index", index))
		{
		}
	}

	[ConvertAs(typeof(ForgetFollowerRequest))]
	public partial interface IForgetFollowerRequest : IRequest<ForgetFollowerRequestParameters>
	{
		string? FollowerCluster { get; set; }

		Elastic.Clients.Elasticsearch.IndexName? FollowerIndex { get; set; }

		Elastic.Clients.Elasticsearch.Uuid? FollowerIndexUuid { get; set; }

		string? LeaderRemoteCluster { get; set; }
	}

	public partial class ForgetFollowerRequest : PlainRequestBase<ForgetFollowerRequestParameters>, IForgetFollowerRequest
	{
		protected IForgetFollowerRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CrossClusterReplicationForgetFollower;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		protected override bool CanBeEmpty => false;
		protected override bool IsEmpty => false;

		///<summary>/{index}/_ccr/forget_follower</summary>
        public ForgetFollowerRequest(Elastic.Clients.Elasticsearch.IndexName index) : base(r => r.Required("index", index))
		{
		}

		[JsonInclude]
		[JsonPropertyName("follower_cluster")]
		public string? FollowerCluster { get; set; }

		[JsonInclude]
		[JsonPropertyName("follower_index")]
		public Elastic.Clients.Elasticsearch.IndexName? FollowerIndex { get; set; }

		[JsonInclude]
		[JsonPropertyName("follower_index_uuid")]
		public Elastic.Clients.Elasticsearch.Uuid? FollowerIndexUuid { get; set; }

		[JsonInclude]
		[JsonPropertyName("leader_remote_cluster")]
		public string? LeaderRemoteCluster { get; set; }
	}

	[ConvertAs(typeof(GetAutoFollowPatternRequest))]
	public partial interface IGetAutoFollowPatternRequest : IRequest<GetAutoFollowPatternRequestParameters>
	{
	}

	public partial class GetAutoFollowPatternRequest : PlainRequestBase<GetAutoFollowPatternRequestParameters>, IGetAutoFollowPatternRequest
	{
		protected IGetAutoFollowPatternRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CrossClusterReplicationGetAutoFollowPattern;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;

		///<summary>/_ccr/auto_follow</summary>
        public GetAutoFollowPatternRequest() : base()
		{
		}

		///<summary>/_ccr/auto_follow/{name}</summary>
        public GetAutoFollowPatternRequest(Elastic.Clients.Elasticsearch.Name? name) : base(r => r.Optional("name", name))
		{
		}
	}

	[ConvertAs(typeof(PauseAutoFollowPatternRequest))]
	public partial interface IPauseAutoFollowPatternRequest : IRequest<PauseAutoFollowPatternRequestParameters>
	{
	}

	public partial class PauseAutoFollowPatternRequest : PlainRequestBase<PauseAutoFollowPatternRequestParameters>, IPauseAutoFollowPatternRequest
	{
		protected IPauseAutoFollowPatternRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CrossClusterReplicationPauseAutoFollowPattern;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => false;
		protected override bool IsEmpty => false;

		///<summary>/_ccr/auto_follow/{name}/pause</summary>
        public PauseAutoFollowPatternRequest(Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("name", name))
		{
		}
	}

	[ConvertAs(typeof(PauseFollowRequest))]
	public partial interface IPauseFollowRequest : IRequest<PauseFollowRequestParameters>
	{
	}

	public partial class PauseFollowRequest : PlainRequestBase<PauseFollowRequestParameters>, IPauseFollowRequest
	{
		protected IPauseFollowRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CrossClusterReplicationPauseFollow;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => false;
		protected override bool IsEmpty => false;

		///<summary>/{index}/_ccr/pause_follow</summary>
        public PauseFollowRequest(Elastic.Clients.Elasticsearch.IndexName index) : base(r => r.Required("index", index))
		{
		}
	}

	[ConvertAs(typeof(PutAutoFollowPatternRequest))]
	public partial interface IPutAutoFollowPatternRequest : IRequest<PutAutoFollowPatternRequestParameters>
	{
		string RemoteCluster { get; set; }

		Elastic.Clients.Elasticsearch.IndexPattern? FollowIndexPattern { get; set; }

		Elastic.Clients.Elasticsearch.IndexPatterns? LeaderIndexPatterns { get; set; }

		Elastic.Clients.Elasticsearch.IndexPatterns? LeaderIndexExclusionPatterns { get; set; }

		int? MaxOutstandingReadRequests { get; set; }

		Dictionary<string, object>? Settings { get; set; }

		int? MaxOutstandingWriteRequests { get; set; }

		Elastic.Clients.Elasticsearch.Time? ReadPollTimeout { get; set; }

		int? MaxReadRequestOperationCount { get; set; }

		Elastic.Clients.Elasticsearch.ByteSize? MaxReadRequestSize { get; set; }

		Elastic.Clients.Elasticsearch.Time? MaxRetryDelay { get; set; }

		int? MaxWriteBufferCount { get; set; }

		Elastic.Clients.Elasticsearch.ByteSize? MaxWriteBufferSize { get; set; }

		int? MaxWriteRequestOperationCount { get; set; }

		Elastic.Clients.Elasticsearch.ByteSize? MaxWriteRequestSize { get; set; }
	}

	public partial class PutAutoFollowPatternRequest : PlainRequestBase<PutAutoFollowPatternRequestParameters>, IPutAutoFollowPatternRequest
	{
		protected IPutAutoFollowPatternRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CrossClusterReplicationPutAutoFollowPattern;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => true;
		protected override bool CanBeEmpty => false;
		protected override bool IsEmpty => false;

		///<summary>/_ccr/auto_follow/{name}</summary>
        public PutAutoFollowPatternRequest(Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("name", name))
		{
		}

		[JsonInclude]
		[JsonPropertyName("remote_cluster")]
		public string RemoteCluster { get; set; }

		[JsonInclude]
		[JsonPropertyName("follow_index_pattern")]
		public Elastic.Clients.Elasticsearch.IndexPattern? FollowIndexPattern { get; set; }

		[JsonInclude]
		[JsonPropertyName("leader_index_patterns")]
		public Elastic.Clients.Elasticsearch.IndexPatterns? LeaderIndexPatterns { get; set; }

		[JsonInclude]
		[JsonPropertyName("leader_index_exclusion_patterns")]
		public Elastic.Clients.Elasticsearch.IndexPatterns? LeaderIndexExclusionPatterns { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_outstanding_read_requests")]
		public int? MaxOutstandingReadRequests { get; set; }

		[JsonInclude]
		[JsonPropertyName("settings")]
		public Dictionary<string, object>? Settings { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_outstanding_write_requests")]
		public int? MaxOutstandingWriteRequests { get; set; }

		[JsonInclude]
		[JsonPropertyName("read_poll_timeout")]
		public Elastic.Clients.Elasticsearch.Time? ReadPollTimeout { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_read_request_operation_count")]
		public int? MaxReadRequestOperationCount { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_read_request_size")]
		public Elastic.Clients.Elasticsearch.ByteSize? MaxReadRequestSize { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_retry_delay")]
		public Elastic.Clients.Elasticsearch.Time? MaxRetryDelay { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_write_buffer_count")]
		public int? MaxWriteBufferCount { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_write_buffer_size")]
		public Elastic.Clients.Elasticsearch.ByteSize? MaxWriteBufferSize { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_write_request_operation_count")]
		public int? MaxWriteRequestOperationCount { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_write_request_size")]
		public Elastic.Clients.Elasticsearch.ByteSize? MaxWriteRequestSize { get; set; }
	}

	[ConvertAs(typeof(ResumeAutoFollowPatternRequest))]
	public partial interface IResumeAutoFollowPatternRequest : IRequest<ResumeAutoFollowPatternRequestParameters>
	{
	}

	public partial class ResumeAutoFollowPatternRequest : PlainRequestBase<ResumeAutoFollowPatternRequestParameters>, IResumeAutoFollowPatternRequest
	{
		protected IResumeAutoFollowPatternRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CrossClusterReplicationResumeAutoFollowPattern;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => false;
		protected override bool IsEmpty => false;

		///<summary>/_ccr/auto_follow/{name}/resume</summary>
        public ResumeAutoFollowPatternRequest(Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("name", name))
		{
		}
	}

	[ConvertAs(typeof(ResumeFollowRequest))]
	public partial interface IResumeFollowRequest : IRequest<ResumeFollowRequestParameters>
	{
		long? MaxOutstandingReadRequests { get; set; }

		long? MaxOutstandingWriteRequests { get; set; }

		long? MaxReadRequestOperationCount { get; set; }

		string? MaxReadRequestSize { get; set; }

		Elastic.Clients.Elasticsearch.Time? MaxRetryDelay { get; set; }

		long? MaxWriteBufferCount { get; set; }

		string? MaxWriteBufferSize { get; set; }

		long? MaxWriteRequestOperationCount { get; set; }

		string? MaxWriteRequestSize { get; set; }

		Elastic.Clients.Elasticsearch.Time? ReadPollTimeout { get; set; }
	}

	public partial class ResumeFollowRequest : PlainRequestBase<ResumeFollowRequestParameters>, IResumeFollowRequest
	{
		protected IResumeFollowRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CrossClusterReplicationResumeFollow;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		protected override bool CanBeEmpty => false;
		protected override bool IsEmpty => false;

		///<summary>/{index}/_ccr/resume_follow</summary>
        public ResumeFollowRequest(Elastic.Clients.Elasticsearch.IndexName index) : base(r => r.Required("index", index))
		{
		}

		[JsonInclude]
		[JsonPropertyName("max_outstanding_read_requests")]
		public long? MaxOutstandingReadRequests { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_outstanding_write_requests")]
		public long? MaxOutstandingWriteRequests { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_read_request_operation_count")]
		public long? MaxReadRequestOperationCount { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_read_request_size")]
		public string? MaxReadRequestSize { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_retry_delay")]
		public Elastic.Clients.Elasticsearch.Time? MaxRetryDelay { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_write_buffer_count")]
		public long? MaxWriteBufferCount { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_write_buffer_size")]
		public string? MaxWriteBufferSize { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_write_request_operation_count")]
		public long? MaxWriteRequestOperationCount { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_write_request_size")]
		public string? MaxWriteRequestSize { get; set; }

		[JsonInclude]
		[JsonPropertyName("read_poll_timeout")]
		public Elastic.Clients.Elasticsearch.Time? ReadPollTimeout { get; set; }
	}

	[ConvertAs(typeof(StatsRequest))]
	public partial interface IStatsRequest : IRequest<StatsRequestParameters>
	{
	}

	public partial class StatsRequest : PlainRequestBase<StatsRequestParameters>, IStatsRequest
	{
		protected IStatsRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CrossClusterReplicationStats;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;

		///<summary>/_ccr/stats</summary>
        public StatsRequest() : base()
		{
		}
	}

	[ConvertAs(typeof(UnfollowRequest))]
	public partial interface IUnfollowRequest : IRequest<UnfollowRequestParameters>
	{
	}

	public partial class UnfollowRequest : PlainRequestBase<UnfollowRequestParameters>, IUnfollowRequest
	{
		protected IUnfollowRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CrossClusterReplicationUnfollow;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => false;
		protected override bool IsEmpty => false;

		///<summary>/{index}/_ccr/unfollow</summary>
        public UnfollowRequest(Elastic.Clients.Elasticsearch.IndexName index) : base(r => r.Required("index", index))
		{
		}
	}
}
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

#nullable restore
namespace Elastic.Clients.Elasticsearch.Ccr
{
	public partial class DeleteAutoFollowPatternDescriptor : RequestDescriptorBase<DeleteAutoFollowPatternDescriptor, DeleteAutoFollowPatternRequestParameters, IDeleteAutoFollowPatternRequest>, IDeleteAutoFollowPatternRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CrossClusterReplicationDeleteAutoFollowPattern;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		///<summary>/_ccr/auto_follow/{name}</summary>
        public DeleteAutoFollowPatternDescriptor(Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("name", name))
		{
		}
	}

	public partial class FollowDescriptor : RequestDescriptorBase<FollowDescriptor, FollowRequestParameters, IFollowRequest>, IFollowRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CrossClusterReplicationFollow;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
		///<summary>/{index}/_ccr/follow</summary>
        public FollowDescriptor(Elastic.Clients.Elasticsearch.IndexName index) : base(r => r.Required("index", index))
		{
		}

		Elastic.Clients.Elasticsearch.IndexName? IFollowRequest.LeaderIndex { get; set; }

		long? IFollowRequest.MaxOutstandingReadRequests { get; set; }

		long? IFollowRequest.MaxOutstandingWriteRequests { get; set; }

		long? IFollowRequest.MaxReadRequestOperationCount { get; set; }

		string? IFollowRequest.MaxReadRequestSize { get; set; }

		Elastic.Clients.Elasticsearch.Time? IFollowRequest.MaxRetryDelay { get; set; }

		long? IFollowRequest.MaxWriteBufferCount { get; set; }

		string? IFollowRequest.MaxWriteBufferSize { get; set; }

		long? IFollowRequest.MaxWriteRequestOperationCount { get; set; }

		string? IFollowRequest.MaxWriteRequestSize { get; set; }

		Elastic.Clients.Elasticsearch.Time? IFollowRequest.ReadPollTimeout { get; set; }

		string? IFollowRequest.RemoteCluster { get; set; }

		public FollowDescriptor WaitForActiveShards(Elastic.Clients.Elasticsearch.WaitForActiveShards? waitForActiveShards) => Qs("wait_for_active_shards", waitForActiveShards);
		public FollowDescriptor LeaderIndex(Elastic.Clients.Elasticsearch.IndexName? leaderIndex) => Assign(leaderIndex, (a, v) => a.LeaderIndex = v);
		public FollowDescriptor MaxOutstandingReadRequests(long? maxOutstandingReadRequests) => Assign(maxOutstandingReadRequests, (a, v) => a.MaxOutstandingReadRequests = v);
		public FollowDescriptor MaxOutstandingWriteRequests(long? maxOutstandingWriteRequests) => Assign(maxOutstandingWriteRequests, (a, v) => a.MaxOutstandingWriteRequests = v);
		public FollowDescriptor MaxReadRequestOperationCount(long? maxReadRequestOperationCount) => Assign(maxReadRequestOperationCount, (a, v) => a.MaxReadRequestOperationCount = v);
		public FollowDescriptor MaxReadRequestSize(string? maxReadRequestSize) => Assign(maxReadRequestSize, (a, v) => a.MaxReadRequestSize = v);
		public FollowDescriptor MaxRetryDelay(Elastic.Clients.Elasticsearch.Time? maxRetryDelay) => Assign(maxRetryDelay, (a, v) => a.MaxRetryDelay = v);
		public FollowDescriptor MaxWriteBufferCount(long? maxWriteBufferCount) => Assign(maxWriteBufferCount, (a, v) => a.MaxWriteBufferCount = v);
		public FollowDescriptor MaxWriteBufferSize(string? maxWriteBufferSize) => Assign(maxWriteBufferSize, (a, v) => a.MaxWriteBufferSize = v);
		public FollowDescriptor MaxWriteRequestOperationCount(long? maxWriteRequestOperationCount) => Assign(maxWriteRequestOperationCount, (a, v) => a.MaxWriteRequestOperationCount = v);
		public FollowDescriptor MaxWriteRequestSize(string? maxWriteRequestSize) => Assign(maxWriteRequestSize, (a, v) => a.MaxWriteRequestSize = v);
		public FollowDescriptor ReadPollTimeout(Elastic.Clients.Elasticsearch.Time? readPollTimeout) => Assign(readPollTimeout, (a, v) => a.ReadPollTimeout = v);
		public FollowDescriptor RemoteCluster(string? remoteCluster) => Assign(remoteCluster, (a, v) => a.RemoteCluster = v);
	}

	public partial class FollowInfoDescriptor : RequestDescriptorBase<FollowInfoDescriptor, FollowInfoRequestParameters, IFollowInfoRequest>, IFollowInfoRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CrossClusterReplicationFollowInfo;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		///<summary>/{index}/_ccr/info</summary>
        public FollowInfoDescriptor(Elastic.Clients.Elasticsearch.Indices index) : base(r => r.Required("index", index))
		{
		}
	}

	public partial class FollowStatsDescriptor : RequestDescriptorBase<FollowStatsDescriptor, FollowStatsRequestParameters, IFollowStatsRequest>, IFollowStatsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CrossClusterReplicationFollowStats;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		///<summary>/{index}/_ccr/stats</summary>
        public FollowStatsDescriptor(Elastic.Clients.Elasticsearch.Indices index) : base(r => r.Required("index", index))
		{
		}
	}

	public partial class ForgetFollowerDescriptor : RequestDescriptorBase<ForgetFollowerDescriptor, ForgetFollowerRequestParameters, IForgetFollowerRequest>, IForgetFollowerRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CrossClusterReplicationForgetFollower;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/{index}/_ccr/forget_follower</summary>
        public ForgetFollowerDescriptor(Elastic.Clients.Elasticsearch.IndexName index) : base(r => r.Required("index", index))
		{
		}

		string? IForgetFollowerRequest.FollowerCluster { get; set; }

		Elastic.Clients.Elasticsearch.IndexName? IForgetFollowerRequest.FollowerIndex { get; set; }

		Elastic.Clients.Elasticsearch.Uuid? IForgetFollowerRequest.FollowerIndexUuid { get; set; }

		string? IForgetFollowerRequest.LeaderRemoteCluster { get; set; }

		public ForgetFollowerDescriptor FollowerCluster(string? followerCluster) => Assign(followerCluster, (a, v) => a.FollowerCluster = v);
		public ForgetFollowerDescriptor FollowerIndex(Elastic.Clients.Elasticsearch.IndexName? followerIndex) => Assign(followerIndex, (a, v) => a.FollowerIndex = v);
		public ForgetFollowerDescriptor FollowerIndexUuid(Elastic.Clients.Elasticsearch.Uuid? followerIndexUuid) => Assign(followerIndexUuid, (a, v) => a.FollowerIndexUuid = v);
		public ForgetFollowerDescriptor LeaderRemoteCluster(string? leaderRemoteCluster) => Assign(leaderRemoteCluster, (a, v) => a.LeaderRemoteCluster = v);
	}

	public partial class GetAutoFollowPatternDescriptor : RequestDescriptorBase<GetAutoFollowPatternDescriptor, GetAutoFollowPatternRequestParameters, IGetAutoFollowPatternRequest>, IGetAutoFollowPatternRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CrossClusterReplicationGetAutoFollowPattern;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		///<summary>/_ccr/auto_follow</summary>
        public GetAutoFollowPatternDescriptor() : base()
		{
		}

		///<summary>/_ccr/auto_follow/{name}</summary>
        public GetAutoFollowPatternDescriptor(Elastic.Clients.Elasticsearch.Name? name) : base(r => r.Optional("name", name))
		{
		}
	}

	public partial class PauseAutoFollowPatternDescriptor : RequestDescriptorBase<PauseAutoFollowPatternDescriptor, PauseAutoFollowPatternRequestParameters, IPauseAutoFollowPatternRequest>, IPauseAutoFollowPatternRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CrossClusterReplicationPauseAutoFollowPattern;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/_ccr/auto_follow/{name}/pause</summary>
        public PauseAutoFollowPatternDescriptor(Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("name", name))
		{
		}
	}

	public partial class PauseFollowDescriptor : RequestDescriptorBase<PauseFollowDescriptor, PauseFollowRequestParameters, IPauseFollowRequest>, IPauseFollowRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CrossClusterReplicationPauseFollow;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/{index}/_ccr/pause_follow</summary>
        public PauseFollowDescriptor(Elastic.Clients.Elasticsearch.IndexName index) : base(r => r.Required("index", index))
		{
		}
	}

	public partial class PutAutoFollowPatternDescriptor : RequestDescriptorBase<PutAutoFollowPatternDescriptor, PutAutoFollowPatternRequestParameters, IPutAutoFollowPatternRequest>, IPutAutoFollowPatternRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CrossClusterReplicationPutAutoFollowPattern;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
		///<summary>/_ccr/auto_follow/{name}</summary>
        public PutAutoFollowPatternDescriptor(Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("name", name))
		{
		}

		string IPutAutoFollowPatternRequest.RemoteCluster { get; set; }

		Elastic.Clients.Elasticsearch.IndexPattern? IPutAutoFollowPatternRequest.FollowIndexPattern { get; set; }

		Elastic.Clients.Elasticsearch.IndexPatterns? IPutAutoFollowPatternRequest.LeaderIndexPatterns { get; set; }

		Elastic.Clients.Elasticsearch.IndexPatterns? IPutAutoFollowPatternRequest.LeaderIndexExclusionPatterns { get; set; }

		int? IPutAutoFollowPatternRequest.MaxOutstandingReadRequests { get; set; }

		Dictionary<string, object>? IPutAutoFollowPatternRequest.Settings { get; set; }

		int? IPutAutoFollowPatternRequest.MaxOutstandingWriteRequests { get; set; }

		Elastic.Clients.Elasticsearch.Time? IPutAutoFollowPatternRequest.ReadPollTimeout { get; set; }

		int? IPutAutoFollowPatternRequest.MaxReadRequestOperationCount { get; set; }

		Elastic.Clients.Elasticsearch.ByteSize? IPutAutoFollowPatternRequest.MaxReadRequestSize { get; set; }

		Elastic.Clients.Elasticsearch.Time? IPutAutoFollowPatternRequest.MaxRetryDelay { get; set; }

		int? IPutAutoFollowPatternRequest.MaxWriteBufferCount { get; set; }

		Elastic.Clients.Elasticsearch.ByteSize? IPutAutoFollowPatternRequest.MaxWriteBufferSize { get; set; }

		int? IPutAutoFollowPatternRequest.MaxWriteRequestOperationCount { get; set; }

		Elastic.Clients.Elasticsearch.ByteSize? IPutAutoFollowPatternRequest.MaxWriteRequestSize { get; set; }

		public PutAutoFollowPatternDescriptor RemoteCluster(string remoteCluster) => Assign(remoteCluster, (a, v) => a.RemoteCluster = v);
		public PutAutoFollowPatternDescriptor FollowIndexPattern(Elastic.Clients.Elasticsearch.IndexPattern? followIndexPattern) => Assign(followIndexPattern, (a, v) => a.FollowIndexPattern = v);
		public PutAutoFollowPatternDescriptor LeaderIndexPatterns(Elastic.Clients.Elasticsearch.IndexPatterns? leaderIndexPatterns) => Assign(leaderIndexPatterns, (a, v) => a.LeaderIndexPatterns = v);
		public PutAutoFollowPatternDescriptor LeaderIndexExclusionPatterns(Elastic.Clients.Elasticsearch.IndexPatterns? leaderIndexExclusionPatterns) => Assign(leaderIndexExclusionPatterns, (a, v) => a.LeaderIndexExclusionPatterns = v);
		public PutAutoFollowPatternDescriptor MaxOutstandingReadRequests(int? maxOutstandingReadRequests) => Assign(maxOutstandingReadRequests, (a, v) => a.MaxOutstandingReadRequests = v);
		public PutAutoFollowPatternDescriptor Settings(Dictionary<string, object>? settings) => Assign(settings, (a, v) => a.Settings = v);
		public PutAutoFollowPatternDescriptor MaxOutstandingWriteRequests(int? maxOutstandingWriteRequests) => Assign(maxOutstandingWriteRequests, (a, v) => a.MaxOutstandingWriteRequests = v);
		public PutAutoFollowPatternDescriptor ReadPollTimeout(Elastic.Clients.Elasticsearch.Time? readPollTimeout) => Assign(readPollTimeout, (a, v) => a.ReadPollTimeout = v);
		public PutAutoFollowPatternDescriptor MaxReadRequestOperationCount(int? maxReadRequestOperationCount) => Assign(maxReadRequestOperationCount, (a, v) => a.MaxReadRequestOperationCount = v);
		public PutAutoFollowPatternDescriptor MaxReadRequestSize(Elastic.Clients.Elasticsearch.ByteSize? maxReadRequestSize) => Assign(maxReadRequestSize, (a, v) => a.MaxReadRequestSize = v);
		public PutAutoFollowPatternDescriptor MaxRetryDelay(Elastic.Clients.Elasticsearch.Time? maxRetryDelay) => Assign(maxRetryDelay, (a, v) => a.MaxRetryDelay = v);
		public PutAutoFollowPatternDescriptor MaxWriteBufferCount(int? maxWriteBufferCount) => Assign(maxWriteBufferCount, (a, v) => a.MaxWriteBufferCount = v);
		public PutAutoFollowPatternDescriptor MaxWriteBufferSize(Elastic.Clients.Elasticsearch.ByteSize? maxWriteBufferSize) => Assign(maxWriteBufferSize, (a, v) => a.MaxWriteBufferSize = v);
		public PutAutoFollowPatternDescriptor MaxWriteRequestOperationCount(int? maxWriteRequestOperationCount) => Assign(maxWriteRequestOperationCount, (a, v) => a.MaxWriteRequestOperationCount = v);
		public PutAutoFollowPatternDescriptor MaxWriteRequestSize(Elastic.Clients.Elasticsearch.ByteSize? maxWriteRequestSize) => Assign(maxWriteRequestSize, (a, v) => a.MaxWriteRequestSize = v);
	}

	public partial class ResumeAutoFollowPatternDescriptor : RequestDescriptorBase<ResumeAutoFollowPatternDescriptor, ResumeAutoFollowPatternRequestParameters, IResumeAutoFollowPatternRequest>, IResumeAutoFollowPatternRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CrossClusterReplicationResumeAutoFollowPattern;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/_ccr/auto_follow/{name}/resume</summary>
        public ResumeAutoFollowPatternDescriptor(Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("name", name))
		{
		}
	}

	public partial class ResumeFollowDescriptor : RequestDescriptorBase<ResumeFollowDescriptor, ResumeFollowRequestParameters, IResumeFollowRequest>, IResumeFollowRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CrossClusterReplicationResumeFollow;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/{index}/_ccr/resume_follow</summary>
        public ResumeFollowDescriptor(Elastic.Clients.Elasticsearch.IndexName index) : base(r => r.Required("index", index))
		{
		}

		long? IResumeFollowRequest.MaxOutstandingReadRequests { get; set; }

		long? IResumeFollowRequest.MaxOutstandingWriteRequests { get; set; }

		long? IResumeFollowRequest.MaxReadRequestOperationCount { get; set; }

		string? IResumeFollowRequest.MaxReadRequestSize { get; set; }

		Elastic.Clients.Elasticsearch.Time? IResumeFollowRequest.MaxRetryDelay { get; set; }

		long? IResumeFollowRequest.MaxWriteBufferCount { get; set; }

		string? IResumeFollowRequest.MaxWriteBufferSize { get; set; }

		long? IResumeFollowRequest.MaxWriteRequestOperationCount { get; set; }

		string? IResumeFollowRequest.MaxWriteRequestSize { get; set; }

		Elastic.Clients.Elasticsearch.Time? IResumeFollowRequest.ReadPollTimeout { get; set; }

		public ResumeFollowDescriptor MaxOutstandingReadRequests(long? maxOutstandingReadRequests) => Assign(maxOutstandingReadRequests, (a, v) => a.MaxOutstandingReadRequests = v);
		public ResumeFollowDescriptor MaxOutstandingWriteRequests(long? maxOutstandingWriteRequests) => Assign(maxOutstandingWriteRequests, (a, v) => a.MaxOutstandingWriteRequests = v);
		public ResumeFollowDescriptor MaxReadRequestOperationCount(long? maxReadRequestOperationCount) => Assign(maxReadRequestOperationCount, (a, v) => a.MaxReadRequestOperationCount = v);
		public ResumeFollowDescriptor MaxReadRequestSize(string? maxReadRequestSize) => Assign(maxReadRequestSize, (a, v) => a.MaxReadRequestSize = v);
		public ResumeFollowDescriptor MaxRetryDelay(Elastic.Clients.Elasticsearch.Time? maxRetryDelay) => Assign(maxRetryDelay, (a, v) => a.MaxRetryDelay = v);
		public ResumeFollowDescriptor MaxWriteBufferCount(long? maxWriteBufferCount) => Assign(maxWriteBufferCount, (a, v) => a.MaxWriteBufferCount = v);
		public ResumeFollowDescriptor MaxWriteBufferSize(string? maxWriteBufferSize) => Assign(maxWriteBufferSize, (a, v) => a.MaxWriteBufferSize = v);
		public ResumeFollowDescriptor MaxWriteRequestOperationCount(long? maxWriteRequestOperationCount) => Assign(maxWriteRequestOperationCount, (a, v) => a.MaxWriteRequestOperationCount = v);
		public ResumeFollowDescriptor MaxWriteRequestSize(string? maxWriteRequestSize) => Assign(maxWriteRequestSize, (a, v) => a.MaxWriteRequestSize = v);
		public ResumeFollowDescriptor ReadPollTimeout(Elastic.Clients.Elasticsearch.Time? readPollTimeout) => Assign(readPollTimeout, (a, v) => a.ReadPollTimeout = v);
	}

	public partial class StatsDescriptor : RequestDescriptorBase<StatsDescriptor, StatsRequestParameters, IStatsRequest>, IStatsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CrossClusterReplicationStats;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		///<summary>/_ccr/stats</summary>
        public StatsDescriptor() : base()
		{
		}
	}

	public partial class UnfollowDescriptor : RequestDescriptorBase<UnfollowDescriptor, UnfollowRequestParameters, IUnfollowRequest>, IUnfollowRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.CrossClusterReplicationUnfollow;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/{index}/_ccr/unfollow</summary>
        public UnfollowDescriptor(Elastic.Clients.Elasticsearch.IndexName index) : base(r => r.Required("index", index))
		{
		}
	}
}
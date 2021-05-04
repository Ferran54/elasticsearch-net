// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗  
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝  
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// -----------------------------------------------
//  
// This file is automatically generated 
// Please do not edit these files manually
// Run the following in the root of the repos:
//
// 		*NIX 		:	./build.sh codegen
// 		Windows 	:	build.bat codegen
//
// -----------------------------------------------
// ReSharper disable RedundantUsingDirective
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using Elasticsearch.Net;
using Elasticsearch.Net.Utf8Json;
using Elasticsearch.Net.Specification.AsyncSearchApi;
using Elasticsearch.Net.Specification.AutoscalingApi;
using Elasticsearch.Net.Specification.CatApi;
using Elasticsearch.Net.Specification.ClusterApi;
using Elasticsearch.Net.Specification.CrossClusterReplicationApi;
using Elasticsearch.Net.Specification.DanglingIndicesApi;
using Elasticsearch.Net.Specification.EnrichApi;
using Elasticsearch.Net.Specification.EqlApi;
using Elasticsearch.Net.Specification.FeaturesApi;
using Elasticsearch.Net.Specification.FleetApi;
using Elasticsearch.Net.Specification.GraphApi;
using Elasticsearch.Net.Specification.IndexLifecycleManagementApi;
using Elasticsearch.Net.Specification.IndicesApi;
using Elasticsearch.Net.Specification.IngestApi;
using Elasticsearch.Net.Specification.LicenseApi;
using Elasticsearch.Net.Specification.LogstashApi;
using Elasticsearch.Net.Specification.MachineLearningApi;
using Elasticsearch.Net.Specification.MigrationApi;
using Elasticsearch.Net.Specification.NodesApi;
using Elasticsearch.Net.Specification.RollupApi;
using Elasticsearch.Net.Specification.SearchableSnapshotsApi;
using Elasticsearch.Net.Specification.SecurityApi;
using Elasticsearch.Net.Specification.ShutdownApi;
using Elasticsearch.Net.Specification.SnapshotApi;
using Elasticsearch.Net.Specification.SnapshotLifecycleManagementApi;
using Elasticsearch.Net.Specification.SqlApi;
using Elasticsearch.Net.Specification.TasksApi;
using Elasticsearch.Net.Specification.TextStructureApi;
using Elasticsearch.Net.Specification.TransformApi;
using Elasticsearch.Net.Specification.WatcherApi;
using Elasticsearch.Net.Specification.XPackApi;

// ReSharper disable UnusedTypeParameter
namespace Nest
{
	public abstract partial class PlainRequestBase<TParameters>
	{
		///<summary>Include the stack trace of returned errors.</summary>
		public bool? ErrorTrace
		{
			get => Q<bool? >("error_trace");
			set => Q("error_trace", value);
		}

		///<summary>
		/// A comma-separated list of filters used to reduce the response.
		/// <para>Use of response filtering can result in a response from Elasticsearch
		/// that cannot be correctly deserialized to the respective response type for the request.
		/// In such situations, use the low level client to issue the request and handle response deserialization</para>
		///</summary>
		public string[] FilterPath
		{
			get => Q<string[]>("filter_path");
			set => Q("filter_path", value);
		}

		///<summary>Return human readable values for statistics.</summary>
		public bool? Human
		{
			get => Q<bool? >("human");
			set => Q("human", value);
		}

		///<summary>Pretty format the returned JSON response.</summary>
		public bool? Pretty
		{
			get => Q<bool? >("pretty");
			set => Q("pretty", value);
		}

		///<summary>The URL-encoded request definition. Useful for libraries that do not accept a request body for non-POST requests.</summary>
		public string SourceQueryString
		{
			get => Q<string>("source");
			set => Q("source", value);
		}
	}
}
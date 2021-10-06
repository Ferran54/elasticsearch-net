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
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Mapping
{
	[ConvertAs(typeof(RuntimeField))]
	public partial interface IRuntimeField
	{
		string? Format { get; set; }

		Elastic.Clients.Elasticsearch.Script? Script { get; set; }

		Elastic.Clients.Elasticsearch.Mapping.RuntimeFieldType Type { get; set; }
	}

	public partial class RuntimeField : Mapping.IRuntimeField
	{
		[JsonInclude]
		[JsonPropertyName("format")]
		public string? Format { get; set; }

		[JsonInclude]
		[JsonPropertyName("script")]
		public Elastic.Clients.Elasticsearch.Script? Script { get; set; }

		[JsonInclude]
		[JsonPropertyName("type")]
		public Elastic.Clients.Elasticsearch.Mapping.RuntimeFieldType Type { get; set; }
	}

	public partial class RuntimeFieldDescriptor : DescriptorBase<RuntimeFieldDescriptor, IRuntimeField>, IRuntimeField
	{
		string? IRuntimeField.Format { get; set; }

		Elastic.Clients.Elasticsearch.Script? IRuntimeField.Script { get; set; }

		Elastic.Clients.Elasticsearch.Mapping.RuntimeFieldType IRuntimeField.Type { get; set; }
	}
}
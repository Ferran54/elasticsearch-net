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
namespace Elastic.Clients.Elasticsearch.Ingest
{
	public abstract partial class ProcessorBase
	{
		[JsonInclude]
		[JsonPropertyName("if")]
		public string? If { get; set; }

		[JsonInclude]
		[JsonPropertyName("ignore_failure")]
		public bool? IgnoreFailure { get; set; }

		[JsonInclude]
		[JsonPropertyName("on_failure")]
		public IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? OnFailure { get; set; }

		[JsonInclude]
		[JsonPropertyName("tag")]
		public string? Tag { get; set; }
	}

	public sealed partial class ProcessorBaseDescriptor : DescriptorBase<ProcessorBaseDescriptor>
	{
		internal ProcessorBaseDescriptor(Action<ProcessorBaseDescriptor> configure) => configure.Invoke(this);
		public ProcessorBaseDescriptor() : base()
		{
		}

		private string? IfValue { get; set; }

		private bool? IgnoreFailureValue { get; set; }

		private IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? OnFailureValue { get; set; }

		private string? TagValue { get; set; }

		public ProcessorBaseDescriptor If(string? ifValue)
		{
			IfValue = ifValue;
			return Self;
		}

		public ProcessorBaseDescriptor IgnoreFailure(bool? ignoreFailure = true)
		{
			IgnoreFailureValue = ignoreFailure;
			return Self;
		}

		public ProcessorBaseDescriptor OnFailure(IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? onFailure)
		{
			OnFailureValue = onFailure;
			return Self;
		}

		public ProcessorBaseDescriptor Tag(string? tag)
		{
			TagValue = tag;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (!string.IsNullOrEmpty(IfValue))
			{
				writer.WritePropertyName("if");
				writer.WriteStringValue(IfValue);
			}

			if (IgnoreFailureValue.HasValue)
			{
				writer.WritePropertyName("ignore_failure");
				writer.WriteBooleanValue(IgnoreFailureValue.Value);
			}

			if (OnFailureValue is not null)
			{
				writer.WritePropertyName("on_failure");
				JsonSerializer.Serialize(writer, OnFailureValue, options);
			}

			if (!string.IsNullOrEmpty(TagValue))
			{
				writer.WritePropertyName("tag");
				writer.WriteStringValue(TagValue);
			}

			writer.WriteEndObject();
		}
	}
}
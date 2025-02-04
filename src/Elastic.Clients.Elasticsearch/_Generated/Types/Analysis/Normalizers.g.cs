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
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Analysis
{
	public partial class Normalizers : IsADictionaryBase<string, INormalizer>
	{
		public Normalizers()
		{
		}

		public Normalizers(IDictionary<string, INormalizer> container) : base(container)
		{
		}

		public void Add(string name, INormalizer normalizers) => BackingDictionary.Add(name, normalizers);
	}

	internal sealed partial class NormalizerInterfaceConverter
	{
		private static INormalizer DeserializeVariant(string type, ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			switch (type)
			{
				case "custom":
					return JsonSerializer.Deserialize<CustomNormalizer>(ref reader, options);
				case "lowercase":
					return JsonSerializer.Deserialize<LowercaseNormalizer>(ref reader, options);
				default:
					throw new JsonException("Encounted an unknown variant type which could not be deserialised.");
			}
		}
	}

	public partial interface INormalizer
	{
		public string Type { get; }
	}
}
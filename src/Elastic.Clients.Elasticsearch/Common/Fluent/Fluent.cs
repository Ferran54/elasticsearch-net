// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.

using System;
using System.Runtime.CompilerServices;

namespace Elastic.Clients.Elasticsearch;

internal static class Fluent
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static TDescriptor Assign<TDescriptor, TValue>(TDescriptor self, TValue value, Action<TDescriptor, TValue> assign)
		where TDescriptor : DescriptorBase<TDescriptor>
	{
		assign(self, value);
		return self;
	}
}

using System;
using System.Runtime.InteropServices;

namespace PrimeFuncPack.Core.Tests;

internal static partial class AssertHelper
{
    private static ReadOnlySpan<byte> InnerToBytes<T>(scoped ref readonly T value)
        where T : struct
    {
        // A defensive copy of the referenced struct value
        return InnerAsBytes(in value).ToArray();
    }

    private static ReadOnlySpan<byte> InnerAsBytes<T>(scoped ref readonly T value)
        where T : struct
    {
        var valueSpan = MemoryMarshal.CreateReadOnlySpan(in value, 1);
        return MemoryMarshal.AsBytes(valueSpan);
    }
}

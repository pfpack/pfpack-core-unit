using System;
using System.Runtime.InteropServices;

namespace PrimeFuncPack.Core.Tests;

internal static partial class AssertHelper
{
    private static ReadOnlySpan<byte> InnerToBytes<T>(scoped ref readonly T value)
        where T : struct
    {
        var valueSpan = MemoryMarshal.CreateReadOnlySpan(in value, 1);

        return MemoryMarshal.AsBytes(valueSpan)
            .ToArray(); // a defensive copy of the referenced struct value
    }
}

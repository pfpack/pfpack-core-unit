using System;
using System.Runtime.InteropServices;

namespace PrimeFuncPack.Core.Tests;

partial class AssertHelper
{
    private static class StructConverter
    {
        internal static ReadOnlySpan<byte> ToBytes<T>(scoped ref readonly T value)
            where T : struct
        {
            // A defensive copy of the referenced struct value
            return AsBytes(in value).ToArray();
        }

        internal static ReadOnlySpan<byte> AsBytes<T>(scoped ref readonly T value)
            where T : struct
        {
            var valueSpan = MemoryMarshal.CreateReadOnlySpan(in value, 1);
            return MemoryMarshal.AsBytes(valueSpan);
        }
    }
}

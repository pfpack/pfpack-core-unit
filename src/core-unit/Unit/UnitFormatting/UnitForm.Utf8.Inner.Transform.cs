using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace System;

partial class UnitFormUtf8
{
    private static Encoding Encoding => Encoding.UTF8;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static byte[]? InnerGetBytes(ReadOnlySpan<char> chars)
    {
        var bytesCount = Encoding.GetByteCount(chars);
        if (bytesCount == default)
        {
            return null;
        }

        var bytes = new byte[bytesCount];
        var destSpan = new Span<byte>(bytes); // Explicit dest span for clarity
        _ = Encoding.GetBytes(chars, destSpan);
        return bytes;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static ReadOnlySpan<byte> InnerAsSpan(byte[]? bytes)
    {
        Debug.Assert(bytes is null || bytes.Length != default);

        if (bytes is null)
        {
#pragma warning disable IDE0301 // Simplify collection initialization
            return ReadOnlySpan<byte>.Empty;
#pragma warning restore IDE0301 // Simplify collection initialization
        }

        return new(bytes);
    }
}

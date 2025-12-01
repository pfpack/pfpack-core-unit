using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace System;

partial class UnitFormUtf8
{
    private static Encoding Encoding => Encoding.UTF8;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static byte[]? InnerGetBytes(string s)
    {
        var bytesCount = Encoding.GetByteCount(s);
        if (bytesCount == default)
        {
            return null;
        }

        var bytes = new byte[bytesCount];

        var sourceSpan = s.AsSpan();
        var destSpan = new Span<byte>(bytes);
        var bytesWritten = Encoding.GetBytes(sourceSpan, destSpan);
        Debug.Assert(bytesWritten == bytesCount);

        return bytes;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static ReadOnlySpan<byte> InnerToSpan(byte[]? bytes)
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

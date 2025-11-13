using System;
using System.Text;
using Xunit;

namespace PrimeFuncPack.Core.Tests;

partial class UnitFormatTests
{
    private static void Inner_FormatToSpanUtf8_DestLengthIsEqual_ExpectSuccessResult(
        Func<Span<byte>, ReadOnlySpan<char>, (bool Result, int BytesWritten)> testFunc,
        string? format,
        string expectedString)
    {
        var expected = Encoding.UTF8.GetBytes(expectedString);

        var destination = new byte[expected.Length].AsSpan();

        var (actualResult, actualBytesWritten) = testFunc.Invoke(destination, format);

        Assert.True(actualResult);
        Assert.Equal(expected.Length, actualBytesWritten);
        Assert.Equal(expected, destination);
    }

    private static void Inner_FormatToSpanUtf8_DestLengthIsGreater_ExpectSuccessResult(
        Func<Span<byte>, ReadOnlySpan<char>, (bool Result, int BytesWritten)> testFunc,
        string? format,
        string expectedString)
    {
        var expected = Encoding.UTF8.GetBytes(expectedString);

        const int extraLength = 1;
        const byte filler = byte.MaxValue;

        var destination = new byte[expected.Length + extraLength].AsSpan();
        destination[expected.Length..].Fill(filler);

        var (actualResult, actualBytesWritten) = testFunc.Invoke(destination, format);

        Assert.True(actualResult);
        Assert.Equal(expected.Length, actualBytesWritten);
        Assert.Equal(expected, destination[..expected.Length]);

        var expectedExtra = new byte[extraLength].AsSpan();
        expectedExtra.Fill(filler);
        Assert.Equal(expectedExtra, destination[expected.Length..]);
    }

    private static void Inner_FormatToSpanUtf8_DestLengthIsLess_ExpectFailureResult(
        Func<Span<byte>, ReadOnlySpan<char>, (bool Result, int BytesWritten)> testFunc,
        string? format,
        string expectedString)
    {
        var expectedLength = Encoding.UTF8.GetBytes(expectedString).Length;

        const byte filler = byte.MaxValue;

        var destination = new byte[expectedLength - 1].AsSpan();
        destination.Fill(filler);

        var (actualResult, actualBytesWritten) = testFunc.Invoke(destination, format);

        Assert.False(actualResult);
        Assert.Equal(0, actualBytesWritten);

        var expectedDestination = new byte[destination.Length].AsSpan();
        expectedDestination.Fill(filler);
        Assert.Equal(expectedDestination, destination);
    }
}

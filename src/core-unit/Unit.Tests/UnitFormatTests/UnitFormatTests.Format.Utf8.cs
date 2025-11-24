using System;
using System.Text;
using Xunit;

namespace PrimeFuncPack.Core.Tests;

partial class UnitFormatTests
{
    [Theory]
    [MemberData(nameof(ExpectedFormatCases))]
    public static void FormatToUtf8_ExpectCorrespondingResult(string? format, string expected)
    {
        var expectedBytes = Encoding.UTF8.GetBytes(expected);

        var source = default(Unit);
        var actualBytes = source.FormatToUtf8(format);

        Assert.Equal(expectedBytes, actualBytes);
    }
}

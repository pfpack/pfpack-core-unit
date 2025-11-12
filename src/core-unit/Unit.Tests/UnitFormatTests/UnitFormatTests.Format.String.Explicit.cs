using System;
using Xunit;

namespace PrimeFuncPack.Core.Tests;

partial class UnitFormatTests
{
    [Theory]
    [MemberData(nameof(ExpectedFormatCases))]
    public static void FormatToStringExplicit_ExpectCorrespondingResult(string? format, string expected)
    {
        var source = (IFormattable)default(Unit);
        var actual = source.ToString(format, null);

        Assert.Equal(expected, actual);
    }
}

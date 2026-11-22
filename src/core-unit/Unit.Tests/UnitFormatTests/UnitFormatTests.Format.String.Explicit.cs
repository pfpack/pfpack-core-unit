using System;
using Xunit;

namespace PrimeFuncPack.Core.Tests;

partial class UnitFormatTests
{
    [Theory]
    [MemberData(nameof(ExpectedFormatCases))]
    public static void FormatToStringExplicit_ExpectCorrespondingResult(string? format, string expected)
    {
        var actual = ((IFormattable)UnitInstance).ToString(format, null);
        Assert.Equal(expected, actual);
    }
}

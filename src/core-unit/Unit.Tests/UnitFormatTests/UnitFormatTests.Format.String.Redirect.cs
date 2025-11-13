using System;
using Xunit;

namespace PrimeFuncPack.Core.Tests;

partial class UnitFormatTests
{
    [Theory]
    [MemberData(nameof(ExpectedFormatCases))]
    [Obsolete("Test of Redirect from the legacy pattern to the new method.")]
    public static void FormatToStringRedirect_ExpectCorrespondingResult(string? format, string expected)
    {
        var source = default(Unit);
        var actual = source.ToString(format);

        Assert.Equal(expected, actual);
    }
}

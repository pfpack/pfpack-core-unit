using System;
using Xunit;

namespace PrimeFuncPack.Core.Tests;

public static partial class UnitFormatUnexpectedTests
{
    private static Unit UnitInstance => default;

    private static void AssertUnexpectedFormat<TResult>(Func<string, TResult> formatAction)
    {
        const string UnexpectedFormat = "unexpected-format";
        var exception = Assert.Throws<FormatException>(() => _ = formatAction.Invoke(UnexpectedFormat));
        Assert.Equal($"An unexpected format specifier (\"{UnexpectedFormat}\").", exception.Message);
    }
}

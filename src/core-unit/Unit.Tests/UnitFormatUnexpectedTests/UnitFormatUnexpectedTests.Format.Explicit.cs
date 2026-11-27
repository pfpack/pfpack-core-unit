using System;
using System.Text;
using Xunit;

namespace PrimeFuncPack.Core.Tests;

partial class UnitFormatUnexpectedTests
{
    [Fact]
    public static void ToStringExplicit_ExpectFailure()
        =>
        AssertUnexpectedFormat(format => ((IFormattable)UnitInstance).ToString(
            format,
            null));

    [Fact]
    public static void TryFormatExplicit_ExpectFailure()
       =>
       AssertUnexpectedFormat(format => ((ISpanFormattable)UnitInstance).TryFormat(
           new char[format.Length],
           out _,
           format,
           null));

    [Fact]
    public static void TryFormatToUtf8Explicit_ExpectFailure()
       =>
       AssertUnexpectedFormat(format => ((IUtf8SpanFormattable)UnitInstance).TryFormat(
           new byte[Encoding.UTF8.GetByteCount(format)],
           out _,
           format,
           null));
}

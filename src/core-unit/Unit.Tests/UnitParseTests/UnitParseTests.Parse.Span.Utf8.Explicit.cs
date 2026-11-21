using System;
using System.Text;
using Xunit;

namespace PrimeFuncPack.Core.Tests;

partial class UnitParseTests
{
    [Theory]
    [MemberData(nameof(ParseCases))]
    public static void ParseSpanUtf8Explicit_Succeeds(string? s)
        =>
        Inner_ParseSpanUtf8Explicit_Succeeds<Unit>(s);

    [Theory]
    [MemberData(nameof(ParseCases))]
    public static void TryParseSpanUtf8Explicit_Succeeds(string? s)
        =>
        Inner_TryParseSpanUtf8Explicit_Succeeds<Unit>(s);

    private static void Inner_ParseSpanUtf8Explicit_Succeeds<TUnit>(string? s)
        where TUnit : struct, IUtf8SpanParsable<TUnit>
    {
        ReadOnlySpan<byte> span = s is null ? null : Encoding.UTF8.GetBytes(s);
        var actual = TUnit.Parse(span, null);

        AssertHelper.AssertDefault(in actual);
    }

    private static void Inner_TryParseSpanUtf8Explicit_Succeeds<TUnit>(string? s)
        where TUnit : struct, IUtf8SpanParsable<TUnit>
    {
        ReadOnlySpan<byte> span = s is null ? null : Encoding.UTF8.GetBytes(s);
        var actual = TUnit.TryParse(span, null, out var result);

        Assert.True(actual);
        AssertHelper.AssertDefault(in result);
    }
}

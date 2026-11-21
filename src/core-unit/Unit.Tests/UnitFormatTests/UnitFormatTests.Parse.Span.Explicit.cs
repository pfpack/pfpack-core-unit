using System;
using Xunit;

namespace PrimeFuncPack.Core.Tests;

partial class UnitFormatTests
{
    [Theory]
    [MemberData(nameof(ParseCases))]
    public static void ParseSpanExplicit_Succeeds(string? s)
        =>
        Inner_ParseSpanExplicit_Succeeds<Unit>(s);

    [Theory]
    [MemberData(nameof(ParseCases))]
    public static void TryParseSpanExplicit_Succeeds(string? s)
        =>
        Inner_TryParseSpanExplicit_Succeeds<Unit>(s);

    private static void Inner_ParseSpanExplicit_Succeeds<TUnit>(string? s)
        where TUnit : struct, ISpanParsable<TUnit>
    {
        ReadOnlySpan<char> span = s;
        var actual = TUnit.Parse(span, null);

        AssertHelper.DefaultStruct(in actual);
    }

    private static void Inner_TryParseSpanExplicit_Succeeds<TUnit>(string? s)
        where TUnit : struct, ISpanParsable<TUnit>
    {
        ReadOnlySpan<char> span = s;
        var actual = TUnit.TryParse(span, null, out var result);

        Assert.True(actual);
        AssertHelper.DefaultStruct(in result);
    }
}

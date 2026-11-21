using System;
using Xunit;

namespace PrimeFuncPack.Core.Tests;

partial class UnitParseTests
{
    [Theory]
    [MemberData(nameof(NotNullParseCases))]
    public static void ParseStringExplicit_Succeeds(string s)
        =>
        Inner_ParseStringExplicit_Succeeds<Unit>(s);

    [Theory]
    [MemberData(nameof(NotNullParseCases))]
    public static void TryParseStringExplicit_Succeeds(string s)
        =>
        Inner_TryParseStringExplicit_Succeeds<Unit>(s);

    [Fact]
    public static void ParseStringExplicit_NullInput_Fails()
        =>
        Inner_ParseStringExplicit_NullInput_Fails<Unit>();

    [Fact]
    public static void TryParseStringExplicit_NullInput_Fails()
        =>
        Inner_TryParseStringExplicit_NullInput_Fails<Unit>();

    private static void Inner_ParseStringExplicit_Succeeds<TUnit>(string s)
        where TUnit : struct, IParsable<TUnit>
    {
        var actual = TUnit.Parse(s, null);

        AssertHelper.AssertDefault(in actual);
    }

    private static void Inner_TryParseStringExplicit_Succeeds<TUnit>(string s)
        where TUnit : struct, IParsable<TUnit>
    {
        var actual = TUnit.TryParse(s, null, out var result);

        Assert.True(actual);
        AssertHelper.AssertDefault(in result);
    }

    private static void Inner_ParseStringExplicit_NullInput_Fails<TUnit>()
        where TUnit : struct, IParsable<TUnit>
    {
        _ = Assert.Throws<ArgumentNullException>("s", () => _ = TUnit.Parse(null!, null));
    }

    private static void Inner_TryParseStringExplicit_NullInput_Fails<TUnit>()
        where TUnit : struct, IParsable<TUnit>
    {
        var actual = TUnit.TryParse(null, null, out var result);

        Assert.False(actual);
        AssertHelper.AssertDefault(in result);
    }
}

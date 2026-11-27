using System;
using Xunit;

namespace PrimeFuncPack.Core.Tests;

public static class UnitFactoryTests
{
    [Fact]
    public static void Value_ExpectDefault()
    {
        AssertHelper.AssertDefault(in Unit.Value);
    }

    [Fact]
    public static void New_ExpectDefault()
    {
        var unit = new Unit();
        AssertHelper.AssertDefault(in unit);
    }

    [Fact]
    public static void Get_ExpectDefault()
    {
        var unit = Unit.Get();
        AssertHelper.AssertDefault(in unit);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    public static void From_Int32_ExpectDefault(int value)
    {
        var unit = Unit.From(value);
        AssertHelper.AssertDefault(in unit);
    }

    [Theory]
    [InlineData(null)]
    [InlineData(0)]
    [InlineData(1)]
    public static void From_Int32Nullable_ExpectDefault(int? value)
    {
        var unit = Unit.From(value);
        AssertHelper.AssertDefault(in unit);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("1")]
    public static void From_String_ExpectDefault(string? value)
    {
        var unit = Unit.From(value);
        AssertHelper.AssertDefault(in unit);
    }
}

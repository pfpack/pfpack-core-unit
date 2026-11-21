using System;
using Xunit;

namespace PrimeFuncPack.Core.Tests;

public static class UnitExtensionsFactoryTests
{
    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    public static void ToUnit_Int32_ExpectDefault(int value)
    {
        var unit = value.ToUnit();
        AssertHelper.DefaultStruct(in unit);
    }

    [Theory]
    [InlineData(null)]
    [InlineData(0)]
    [InlineData(1)]
    public static void ToUnit_Int32Nullable_ExpectDefault(int? value)
    {
        var unit = value.ToUnit();
        AssertHelper.DefaultStruct(in unit);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("1")]
    public static void ToUnit_String_ExpectDefault(string? value)
    {
        var unit = value.ToUnit();
        AssertHelper.DefaultStruct(in unit);
    }
}

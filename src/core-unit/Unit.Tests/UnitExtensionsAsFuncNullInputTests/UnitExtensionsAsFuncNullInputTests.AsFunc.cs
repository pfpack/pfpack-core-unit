using System;
using Xunit;

namespace PrimeFuncPack.Core.Tests;

partial class UnitExtensionsAsFuncNullInputTests
{
    [Fact]
    public static void AsFunc00_ActionIsNull_ExpectArgumentNullException()
    {
        Action action = null!;
        _ = Assert.Throws<ArgumentNullException>(ActionParamName, action.AsFunc);
    }

    [Fact]
    public static void AsFunc01_ActionIsNull_ExpectArgumentNullException()
    {
        Action<int> action = null!;
        _ = Assert.Throws<ArgumentNullException>(ActionParamName, action.AsFunc);
    }

    [Fact]

    public static void AsFunc02_ActionIsNull_ExpectArgumentNullException()
    {
        Action<int, int> action = null!;
        _ = Assert.Throws<ArgumentNullException>(ActionParamName, action.AsFunc);
    }

    [Fact]

    public static void AsFunc03_ActionIsNull_ExpectArgumentNullException()
    {
        Action<int, int, int> action = null!;
        _ = Assert.Throws<ArgumentNullException>(ActionParamName, action.AsFunc);
    }

    [Fact]

    public static void AsFunc04_ActionIsNull_ExpectArgumentNullException()
    {
        Action<int, int, int, int> action = null!;
        _ = Assert.Throws<ArgumentNullException>(ActionParamName, action.AsFunc);
    }

    [Fact]

    public static void AsFunc05_ActionIsNull_ExpectArgumentNullException()
    {
        Action<int, int, int, int, int> action = null!;
        _ = Assert.Throws<ArgumentNullException>(ActionParamName, action.AsFunc);
    }

    [Fact]

    public static void AsFunc06_ActionIsNull_ExpectArgumentNullException()
    {
        Action<int, int, int, int, int, int> action = null!;
        _ = Assert.Throws<ArgumentNullException>(ActionParamName, action.AsFunc);
    }

    [Fact]

    public static void AsFunc07_ActionIsNull_ExpectArgumentNullException()
    {
        Action<int, int, int, int, int, int, int> action = null!;
        _ = Assert.Throws<ArgumentNullException>(ActionParamName, action.AsFunc);
    }

    [Fact]

    public static void AsFunc08_ActionIsNull_ExpectArgumentNullException()
    {
        Action<int, int, int, int, int, int, int, int> action = null!;
        _ = Assert.Throws<ArgumentNullException>(ActionParamName, action.AsFunc);
    }

    [Fact]

    public static void AsFunc09_ActionIsNull_ExpectArgumentNullException()
    {
        Action<int, int, int, int, int, int, int, int, int> action = null!;
        _ = Assert.Throws<ArgumentNullException>(ActionParamName, action.AsFunc);
    }

    [Fact]

    public static void AsFunc10_ActionIsNull_ExpectArgumentNullException()
    {
        Action<int, int, int, int, int, int, int, int, int, int> action = null!;
        _ = Assert.Throws<ArgumentNullException>(ActionParamName, action.AsFunc);
    }

    [Fact]

    public static void AsFunc11_ActionIsNull_ExpectArgumentNullException()
    {
        Action<int, int, int, int, int, int, int, int, int, int, int> action = null!;
        _ = Assert.Throws<ArgumentNullException>(ActionParamName, action.AsFunc);
    }

    [Fact]

    public static void AsFunc12_ActionIsNull_ExpectArgumentNullException()
    {
        Action<int, int, int, int, int, int, int, int, int, int, int, int> action = null!;
        _ = Assert.Throws<ArgumentNullException>(ActionParamName, action.AsFunc);
    }

    [Fact]

    public static void AsFunc13_ActionIsNull_ExpectArgumentNullException()
    {
        Action<int, int, int, int, int, int, int, int, int, int, int, int, int> action = null!;
        _ = Assert.Throws<ArgumentNullException>(ActionParamName, action.AsFunc);
    }

    [Fact]

    public static void AsFunc14_ActionIsNull_ExpectArgumentNullException()
    {
        Action<int, int, int, int, int, int, int, int, int, int, int, int, int, int> action = null!;
        _ = Assert.Throws<ArgumentNullException>(ActionParamName, action.AsFunc);
    }

    [Fact]

    public static void AsFunc15_ActionIsNull_ExpectArgumentNullException()
    {
        Action<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int> action = null!;
        _ = Assert.Throws<ArgumentNullException>(ActionParamName, action.AsFunc);
    }

    [Fact]

    public static void AsFunc16_ActionIsNull_ExpectArgumentNullException()
    {
        Action<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int> action = null!;
        _ = Assert.Throws<ArgumentNullException>(ActionParamName, action.AsFunc);
    }
}

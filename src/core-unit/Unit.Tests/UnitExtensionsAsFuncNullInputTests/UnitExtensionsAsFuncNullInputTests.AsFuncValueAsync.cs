using System;
using System.Threading.Tasks;
using Xunit;

namespace PrimeFuncPack.Core.Tests;

partial class UnitExtensionsAsFuncNullInputTests
{
    [Fact]
    public static void AsFuncValueAsync00_FuncIsNull_ExpectArgumentNullException()
    {
        Func<ValueTask> funcAsync = null!;
        _ = Assert.Throws<ArgumentNullException>(FuncValueAsyncParamName, funcAsync.AsFuncValueAsync);
    }

    [Fact]
    public static void AsFuncValueAsync01_FuncIsNull_ExpectArgumentNullException()
    {
        Func<int, ValueTask> funcAsync = null!;
        _ = Assert.Throws<ArgumentNullException>(FuncValueAsyncParamName, funcAsync.AsFuncValueAsync);
    }

    [Fact]

    public static void AsFuncValueAsync02_FuncIsNull_ExpectArgumentNullException()
    {
        Func<int, int, ValueTask> funcAsync = null!;
        _ = Assert.Throws<ArgumentNullException>(FuncValueAsyncParamName, funcAsync.AsFuncValueAsync);
    }

    [Fact]

    public static void AsFuncValueAsync03_FuncIsNull_ExpectArgumentNullException()
    {
        Func<int, int, int, ValueTask> funcAsync = null!;
        _ = Assert.Throws<ArgumentNullException>(FuncValueAsyncParamName, funcAsync.AsFuncValueAsync);
    }

    [Fact]

    public static void AsFuncValueAsync04_FuncIsNull_ExpectArgumentNullException()
    {
        Func<int, int, int, int, ValueTask> funcAsync = null!;
        _ = Assert.Throws<ArgumentNullException>(FuncValueAsyncParamName, funcAsync.AsFuncValueAsync);
    }

    [Fact]

    public static void AsFuncValueAsync05_FuncIsNull_ExpectArgumentNullException()
    {
        Func<int, int, int, int, int, ValueTask> funcAsync = null!;
        _ = Assert.Throws<ArgumentNullException>(FuncValueAsyncParamName, funcAsync.AsFuncValueAsync);
    }

    [Fact]

    public static void AsFuncValueAsync06_FuncIsNull_ExpectArgumentNullException()
    {
        Func<int, int, int, int, int, int, ValueTask> funcAsync = null!;
        _ = Assert.Throws<ArgumentNullException>(FuncValueAsyncParamName, funcAsync.AsFuncValueAsync);
    }

    [Fact]

    public static void AsFuncValueAsync07_FuncIsNull_ExpectArgumentNullException()
    {
        Func<int, int, int, int, int, int, int, ValueTask> funcAsync = null!;
        _ = Assert.Throws<ArgumentNullException>(FuncValueAsyncParamName, funcAsync.AsFuncValueAsync);
    }

    [Fact]

    public static void AsFuncValueAsync08_FuncIsNull_ExpectArgumentNullException()
    {
        Func<int, int, int, int, int, int, int, int, ValueTask> funcAsync = null!;
        _ = Assert.Throws<ArgumentNullException>(FuncValueAsyncParamName, funcAsync.AsFuncValueAsync);
    }

    [Fact]

    public static void AsFuncValueAsync09_FuncIsNull_ExpectArgumentNullException()
    {
        Func<int, int, int, int, int, int, int, int, int, ValueTask> funcAsync = null!;
        _ = Assert.Throws<ArgumentNullException>(FuncValueAsyncParamName, funcAsync.AsFuncValueAsync);
    }

    [Fact]

    public static void AsFuncValueAsync10_FuncIsNull_ExpectArgumentNullException()
    {
        Func<int, int, int, int, int, int, int, int, int, int, ValueTask> funcAsync = null!;
        _ = Assert.Throws<ArgumentNullException>(FuncValueAsyncParamName, funcAsync.AsFuncValueAsync);
    }

    [Fact]

    public static void AsFuncValueAsync11_FuncIsNull_ExpectArgumentNullException()
    {
        Func<int, int, int, int, int, int, int, int, int, int, int, ValueTask> funcAsync = null!;
        _ = Assert.Throws<ArgumentNullException>(FuncValueAsyncParamName, funcAsync.AsFuncValueAsync);
    }

    [Fact]

    public static void AsFuncValueAsync12_FuncIsNull_ExpectArgumentNullException()
    {
        Func<int, int, int, int, int, int, int, int, int, int, int, int, ValueTask> funcAsync = null!;
        _ = Assert.Throws<ArgumentNullException>(FuncValueAsyncParamName, funcAsync.AsFuncValueAsync);
    }

    [Fact]

    public static void AsFuncValueAsync13_FuncIsNull_ExpectArgumentNullException()
    {
        Func<int, int, int, int, int, int, int, int, int, int, int, int, int, ValueTask> funcAsync = null!;
        _ = Assert.Throws<ArgumentNullException>(FuncValueAsyncParamName, funcAsync.AsFuncValueAsync);
    }

    [Fact]

    public static void AsFuncValueAsync14_FuncIsNull_ExpectArgumentNullException()
    {
        Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, ValueTask> funcAsync = null!;
        _ = Assert.Throws<ArgumentNullException>(FuncValueAsyncParamName, funcAsync.AsFuncValueAsync);
    }

    [Fact]

    public static void AsFuncValueAsync15_FuncIsNull_ExpectArgumentNullException()
    {
        Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, ValueTask> funcAsync = null!;
        _ = Assert.Throws<ArgumentNullException>(FuncValueAsyncParamName, funcAsync.AsFuncValueAsync);
    }

    [Fact]

    public static void AsFuncValueAsync16_FuncIsNull_ExpectArgumentNullException()
    {
        Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, ValueTask> funcAsync = null!;
        _ = Assert.Throws<ArgumentNullException>(FuncValueAsyncParamName, funcAsync.AsFuncValueAsync);
    }
}

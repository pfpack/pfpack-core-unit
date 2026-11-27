using System;
using System.Threading.Tasks;
using Xunit;

namespace PrimeFuncPack.Core.Tests;

partial class UnitExtensionsAsFuncNullInputTests
{
    [Fact]
    public static void AsFuncAsync00_FuncIsNull_ExpectArgumentNullException()
    {
        Func<Task> funcAsync = null!;
        _ = Assert.Throws<ArgumentNullException>(FuncAsyncParamName, funcAsync.AsFuncAsync);
    }

    [Fact]
    public static void AsFuncAsync01_FuncIsNull_ExpectArgumentNullException()
    {
        Func<int, Task> funcAsync = null!;
        _ = Assert.Throws<ArgumentNullException>(FuncAsyncParamName, funcAsync.AsFuncAsync);
    }

    [Fact]

    public static void AsFuncAsync02_FuncIsNull_ExpectArgumentNullException()
    {
        Func<int, int, Task> funcAsync = null!;
        _ = Assert.Throws<ArgumentNullException>(FuncAsyncParamName, funcAsync.AsFuncAsync);
    }

    [Fact]

    public static void AsFuncAsync03_FuncIsNull_ExpectArgumentNullException()
    {
        Func<int, int, int, Task> funcAsync = null!;
        _ = Assert.Throws<ArgumentNullException>(FuncAsyncParamName, funcAsync.AsFuncAsync);
    }

    [Fact]

    public static void AsFuncAsync04_FuncIsNull_ExpectArgumentNullException()
    {
        Func<int, int, int, int, Task> funcAsync = null!;
        _ = Assert.Throws<ArgumentNullException>(FuncAsyncParamName, funcAsync.AsFuncAsync);
    }

    [Fact]

    public static void AsFuncAsync05_FuncIsNull_ExpectArgumentNullException()
    {
        Func<int, int, int, int, int, Task> funcAsync = null!;
        _ = Assert.Throws<ArgumentNullException>(FuncAsyncParamName, funcAsync.AsFuncAsync);
    }

    [Fact]

    public static void AsFuncAsync06_FuncIsNull_ExpectArgumentNullException()
    {
        Func<int, int, int, int, int, int, Task> funcAsync = null!;
        _ = Assert.Throws<ArgumentNullException>(FuncAsyncParamName, funcAsync.AsFuncAsync);
    }

    [Fact]

    public static void AsFuncAsync07_FuncIsNull_ExpectArgumentNullException()
    {
        Func<int, int, int, int, int, int, int, Task> funcAsync = null!;
        _ = Assert.Throws<ArgumentNullException>(FuncAsyncParamName, funcAsync.AsFuncAsync);
    }

    [Fact]

    public static void AsFuncAsync08_FuncIsNull_ExpectArgumentNullException()
    {
        Func<int, int, int, int, int, int, int, int, Task> funcAsync = null!;
        _ = Assert.Throws<ArgumentNullException>(FuncAsyncParamName, funcAsync.AsFuncAsync);
    }

    [Fact]

    public static void AsFuncAsync09_FuncIsNull_ExpectArgumentNullException()
    {
        Func<int, int, int, int, int, int, int, int, int, Task> funcAsync = null!;
        _ = Assert.Throws<ArgumentNullException>(FuncAsyncParamName, funcAsync.AsFuncAsync);
    }

    [Fact]

    public static void AsFuncAsync10_FuncIsNull_ExpectArgumentNullException()
    {
        Func<int, int, int, int, int, int, int, int, int, int, Task> funcAsync = null!;
        _ = Assert.Throws<ArgumentNullException>(FuncAsyncParamName, funcAsync.AsFuncAsync);
    }

    [Fact]

    public static void AsFuncAsync11_FuncIsNull_ExpectArgumentNullException()
    {
        Func<int, int, int, int, int, int, int, int, int, int, int, Task> funcAsync = null!;
        _ = Assert.Throws<ArgumentNullException>(FuncAsyncParamName, funcAsync.AsFuncAsync);
    }

    [Fact]

    public static void AsFuncAsync12_FuncIsNull_ExpectArgumentNullException()
    {
        Func<int, int, int, int, int, int, int, int, int, int, int, int, Task> funcAsync = null!;
        _ = Assert.Throws<ArgumentNullException>(FuncAsyncParamName, funcAsync.AsFuncAsync);
    }

    [Fact]

    public static void AsFuncAsync13_FuncIsNull_ExpectArgumentNullException()
    {
        Func<int, int, int, int, int, int, int, int, int, int, int, int, int, Task> funcAsync = null!;
        _ = Assert.Throws<ArgumentNullException>(FuncAsyncParamName, funcAsync.AsFuncAsync);
    }

    [Fact]

    public static void AsFuncAsync14_FuncIsNull_ExpectArgumentNullException()
    {
        Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, Task> funcAsync = null!;
        _ = Assert.Throws<ArgumentNullException>(FuncAsyncParamName, funcAsync.AsFuncAsync);
    }

    [Fact]

    public static void AsFuncAsync15_FuncIsNull_ExpectArgumentNullException()
    {
        Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, Task> funcAsync = null!;
        _ = Assert.Throws<ArgumentNullException>(FuncAsyncParamName, funcAsync.AsFuncAsync);
    }

    [Fact]

    public static void AsFuncAsync16_FuncIsNull_ExpectArgumentNullException()
    {
        Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, Task> funcAsync = null!;
        _ = Assert.Throws<ArgumentNullException>(FuncAsyncParamName, funcAsync.AsFuncAsync);
    }
}

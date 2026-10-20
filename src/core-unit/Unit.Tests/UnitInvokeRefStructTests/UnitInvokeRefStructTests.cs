using System;
using System.Diagnostics;
using Xunit;

namespace PrimeFuncPack.Core.Tests;

public static class UnitInvokeRefStructTests
{
    [Fact]
    public static void InvokeRefStruct_01_ExpectSuccess()
    {
        var arg = AllocateArg();

        var result = Unit.Invoke(
            arg => FillArg(arg, 1),
            arg);

        Assert.Equal(default, result);
        Assert.Equal(arg, [1]);
    }

    [Fact]
    public static void InvokeRefStruct_02_ExpectSuccess()
    {
        var arg1 = AllocateArg();
        var arg2 = AllocateArg();

        var result = Unit.Invoke((
            arg1,
            arg2) =>
        {
            FillArg(arg1, 1);
            FillArg(arg2, 2);
        },
        arg1,
        arg2);

        Assert.Equal(default, result);

        Assert.Equal(arg1, [1]);
        Assert.Equal(arg2, [2]);
    }

    [Fact]
    public static void InvokeRefStruct_03_ExpectSuccess()
    {
        var arg1 = AllocateArg();
        var arg2 = AllocateArg();
        var arg3 = AllocateArg();

        var result = Unit.Invoke((
            arg1,
            arg2,
            arg3) =>
        {
            FillArg(arg1, 1);
            FillArg(arg2, 2);
            FillArg(arg3, 3);
        },
        arg1,
        arg2,
        arg3);

        Assert.Equal(default, result);

        Assert.Equal(arg1, [1]);
        Assert.Equal(arg2, [2]);
        Assert.Equal(arg3, [3]);
    }

    [Fact]
    public static void InvokeRefStruct_04_ExpectSuccess()
    {
        var arg1 = AllocateArg();
        var arg2 = AllocateArg();
        var arg3 = AllocateArg();
        var arg4 = AllocateArg();

        var result = Unit.Invoke((
            arg1,
            arg2,
            arg3,
            arg4) =>
        {
            FillArg(arg1, 1);
            FillArg(arg2, 2);
            FillArg(arg3, 3);
            FillArg(arg4, 4);
        },
        arg1,
        arg2,
        arg3,
        arg4);

        Assert.Equal(default, result);

        Assert.Equal(arg1, [1]);
        Assert.Equal(arg2, [2]);
        Assert.Equal(arg3, [3]);
        Assert.Equal(arg4, [4]);
    }

    [Fact]
    public static void InvokeRefStruct_05_ExpectSuccess()
    {
        var arg1 = AllocateArg();
        var arg2 = AllocateArg();
        var arg3 = AllocateArg();
        var arg4 = AllocateArg();
        var arg5 = AllocateArg();

        var result = Unit.Invoke((
            arg1,
            arg2,
            arg3,
            arg4,
            arg5) =>
        {
            FillArg(arg1, 1);
            FillArg(arg2, 2);
            FillArg(arg3, 3);
            FillArg(arg4, 4);
            FillArg(arg5, 5);
        },
        arg1,
        arg2,
        arg3,
        arg4,
        arg5);

        Assert.Equal(default, result);

        Assert.Equal(arg1, [1]);
        Assert.Equal(arg2, [2]);
        Assert.Equal(arg3, [3]);
        Assert.Equal(arg4, [4]);
        Assert.Equal(arg5, [5]);
    }

    [Fact]
    public static void InvokeRefStruct_06_ExpectSuccess()
    {
        var arg1 = AllocateArg();
        var arg2 = AllocateArg();
        var arg3 = AllocateArg();
        var arg4 = AllocateArg();
        var arg5 = AllocateArg();
        var arg6 = AllocateArg();

        var result = Unit.Invoke((
            arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6) =>
        {
            FillArg(arg1, 1);
            FillArg(arg2, 2);
            FillArg(arg3, 3);
            FillArg(arg4, 4);
            FillArg(arg5, 5);
            FillArg(arg6, 6);
        },
        arg1,
        arg2,
        arg3,
        arg4,
        arg5,
        arg6);

        Assert.Equal(default, result);

        Assert.Equal(arg1, [1]);
        Assert.Equal(arg2, [2]);
        Assert.Equal(arg3, [3]);
        Assert.Equal(arg4, [4]);
        Assert.Equal(arg5, [5]);
        Assert.Equal(arg6, [6]);
    }

    [Fact]
    public static void InvokeRefStruct_07_ExpectSuccess()
    {
        var arg1 = AllocateArg();
        var arg2 = AllocateArg();
        var arg3 = AllocateArg();
        var arg4 = AllocateArg();
        var arg5 = AllocateArg();
        var arg6 = AllocateArg();
        var arg7 = AllocateArg();

        var result = Unit.Invoke((
            arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6,
            arg7) =>
        {
            FillArg(arg1, 1);
            FillArg(arg2, 2);
            FillArg(arg3, 3);
            FillArg(arg4, 4);
            FillArg(arg5, 5);
            FillArg(arg6, 6);
            FillArg(arg7, 7);
        },
        arg1,
        arg2,
        arg3,
        arg4,
        arg5,
        arg6,
        arg7);

        Assert.Equal(default, result);

        Assert.Equal(arg1, [1]);
        Assert.Equal(arg2, [2]);
        Assert.Equal(arg3, [3]);
        Assert.Equal(arg4, [4]);
        Assert.Equal(arg5, [5]);
        Assert.Equal(arg6, [6]);
        Assert.Equal(arg7, [7]);
    }

    [Fact]
    public static void InvokeRefStruct_08_ExpectSuccess()
    {
        var arg1 = AllocateArg();
        var arg2 = AllocateArg();
        var arg3 = AllocateArg();
        var arg4 = AllocateArg();
        var arg5 = AllocateArg();
        var arg6 = AllocateArg();
        var arg7 = AllocateArg();
        var arg8 = AllocateArg();

        var result = Unit.Invoke((
            arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6,
            arg7,
            arg8) =>
        {
            FillArg(arg1, 1);
            FillArg(arg2, 2);
            FillArg(arg3, 3);
            FillArg(arg4, 4);
            FillArg(arg5, 5);
            FillArg(arg6, 6);
            FillArg(arg7, 7);
            FillArg(arg8, 8);
        },
        arg1,
        arg2,
        arg3,
        arg4,
        arg5,
        arg6,
        arg7,
        arg8);

        Assert.Equal(default, result);

        Assert.Equal(arg1, [1]);
        Assert.Equal(arg2, [2]);
        Assert.Equal(arg3, [3]);
        Assert.Equal(arg4, [4]);
        Assert.Equal(arg5, [5]);
        Assert.Equal(arg6, [6]);
        Assert.Equal(arg7, [7]);
        Assert.Equal(arg8, [8]);
    }

    [Fact]
    public static void InvokeRefStruct_09_ExpectSuccess()
    {
        var arg1 = AllocateArg();
        var arg2 = AllocateArg();
        var arg3 = AllocateArg();
        var arg4 = AllocateArg();
        var arg5 = AllocateArg();
        var arg6 = AllocateArg();
        var arg7 = AllocateArg();
        var arg8 = AllocateArg();
        var arg9 = AllocateArg();

        var result = Unit.Invoke((
            arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6,
            arg7,
            arg8,
            arg9) =>
        {
            FillArg(arg1, 1);
            FillArg(arg2, 2);
            FillArg(arg3, 3);
            FillArg(arg4, 4);
            FillArg(arg5, 5);
            FillArg(arg6, 6);
            FillArg(arg7, 7);
            FillArg(arg8, 8);
            FillArg(arg9, 9);
        },
        arg1,
        arg2,
        arg3,
        arg4,
        arg5,
        arg6,
        arg7,
        arg8,
        arg9);

        Assert.Equal(default, result);

        Assert.Equal(arg1, [1]);
        Assert.Equal(arg2, [2]);
        Assert.Equal(arg3, [3]);
        Assert.Equal(arg4, [4]);
        Assert.Equal(arg5, [5]);
        Assert.Equal(arg6, [6]);
        Assert.Equal(arg7, [7]);
        Assert.Equal(arg8, [8]);
        Assert.Equal(arg9, [9]);
    }

    [Fact]
    public static void InvokeRefStruct_10_ExpectSuccess()
    {
        var arg1 = AllocateArg();
        var arg2 = AllocateArg();
        var arg3 = AllocateArg();
        var arg4 = AllocateArg();
        var arg5 = AllocateArg();
        var arg6 = AllocateArg();
        var arg7 = AllocateArg();
        var arg8 = AllocateArg();
        var arg9 = AllocateArg();
        var arg10 = AllocateArg();

        var result = Unit.Invoke((
            arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6,
            arg7,
            arg8,
            arg9,
            arg10) =>
        {
            FillArg(arg1, 1);
            FillArg(arg2, 2);
            FillArg(arg3, 3);
            FillArg(arg4, 4);
            FillArg(arg5, 5);
            FillArg(arg6, 6);
            FillArg(arg7, 7);
            FillArg(arg8, 8);
            FillArg(arg9, 9);
            FillArg(arg10, 10);
        },
        arg1,
        arg2,
        arg3,
        arg4,
        arg5,
        arg6,
        arg7,
        arg8,
        arg9,
        arg10);

        Assert.Equal(default, result);

        Assert.Equal(arg1, [1]);
        Assert.Equal(arg2, [2]);
        Assert.Equal(arg3, [3]);
        Assert.Equal(arg4, [4]);
        Assert.Equal(arg5, [5]);
        Assert.Equal(arg6, [6]);
        Assert.Equal(arg7, [7]);
        Assert.Equal(arg8, [8]);
        Assert.Equal(arg9, [9]);
        Assert.Equal(arg10, [10]);
    }

    [Fact]
    public static void InvokeRefStruct_11_ExpectSuccess()
    {
        var arg1 = AllocateArg();
        var arg2 = AllocateArg();
        var arg3 = AllocateArg();
        var arg4 = AllocateArg();
        var arg5 = AllocateArg();
        var arg6 = AllocateArg();
        var arg7 = AllocateArg();
        var arg8 = AllocateArg();
        var arg9 = AllocateArg();
        var arg10 = AllocateArg();
        var arg11 = AllocateArg();

        var result = Unit.Invoke((
            arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6,
            arg7,
            arg8,
            arg9,
            arg10,
            arg11) =>
        {
            FillArg(arg1, 1);
            FillArg(arg2, 2);
            FillArg(arg3, 3);
            FillArg(arg4, 4);
            FillArg(arg5, 5);
            FillArg(arg6, 6);
            FillArg(arg7, 7);
            FillArg(arg8, 8);
            FillArg(arg9, 9);
            FillArg(arg10, 10);
            FillArg(arg11, 11);
        },
        arg1,
        arg2,
        arg3,
        arg4,
        arg5,
        arg6,
        arg7,
        arg8,
        arg9,
        arg10,
        arg11);

        Assert.Equal(default, result);

        Assert.Equal(arg1, [1]);
        Assert.Equal(arg2, [2]);
        Assert.Equal(arg3, [3]);
        Assert.Equal(arg4, [4]);
        Assert.Equal(arg5, [5]);
        Assert.Equal(arg6, [6]);
        Assert.Equal(arg7, [7]);
        Assert.Equal(arg8, [8]);
        Assert.Equal(arg9, [9]);
        Assert.Equal(arg10, [10]);
        Assert.Equal(arg11, [11]);
    }

    [Fact]
    public static void InvokeRefStruct_12_ExpectSuccess()
    {
        var arg1 = AllocateArg();
        var arg2 = AllocateArg();
        var arg3 = AllocateArg();
        var arg4 = AllocateArg();
        var arg5 = AllocateArg();
        var arg6 = AllocateArg();
        var arg7 = AllocateArg();
        var arg8 = AllocateArg();
        var arg9 = AllocateArg();
        var arg10 = AllocateArg();
        var arg11 = AllocateArg();
        var arg12 = AllocateArg();

        var result = Unit.Invoke((
            arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6,
            arg7,
            arg8,
            arg9,
            arg10,
            arg11,
            arg12) =>
        {
            FillArg(arg1, 1);
            FillArg(arg2, 2);
            FillArg(arg3, 3);
            FillArg(arg4, 4);
            FillArg(arg5, 5);
            FillArg(arg6, 6);
            FillArg(arg7, 7);
            FillArg(arg8, 8);
            FillArg(arg9, 9);
            FillArg(arg10, 10);
            FillArg(arg11, 11);
            FillArg(arg12, 12);
        },
        arg1,
        arg2,
        arg3,
        arg4,
        arg5,
        arg6,
        arg7,
        arg8,
        arg9,
        arg10,
        arg11,
        arg12);

        Assert.Equal(default, result);

        Assert.Equal(arg1, [1]);
        Assert.Equal(arg2, [2]);
        Assert.Equal(arg3, [3]);
        Assert.Equal(arg4, [4]);
        Assert.Equal(arg5, [5]);
        Assert.Equal(arg6, [6]);
        Assert.Equal(arg7, [7]);
        Assert.Equal(arg8, [8]);
        Assert.Equal(arg9, [9]);
        Assert.Equal(arg10, [10]);
        Assert.Equal(arg11, [11]);
        Assert.Equal(arg12, [12]);
    }

    [Fact]
    public static void InvokeRefStruct_13_ExpectSuccess()
    {
        var arg1 = AllocateArg();
        var arg2 = AllocateArg();
        var arg3 = AllocateArg();
        var arg4 = AllocateArg();
        var arg5 = AllocateArg();
        var arg6 = AllocateArg();
        var arg7 = AllocateArg();
        var arg8 = AllocateArg();
        var arg9 = AllocateArg();
        var arg10 = AllocateArg();
        var arg11 = AllocateArg();
        var arg12 = AllocateArg();
        var arg13 = AllocateArg();

        var result = Unit.Invoke((
            arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6,
            arg7,
            arg8,
            arg9,
            arg10,
            arg11,
            arg12,
            arg13) =>
        {
            FillArg(arg1, 1);
            FillArg(arg2, 2);
            FillArg(arg3, 3);
            FillArg(arg4, 4);
            FillArg(arg5, 5);
            FillArg(arg6, 6);
            FillArg(arg7, 7);
            FillArg(arg8, 8);
            FillArg(arg9, 9);
            FillArg(arg10, 10);
            FillArg(arg11, 11);
            FillArg(arg12, 12);
            FillArg(arg13, 13);
        },
        arg1,
        arg2,
        arg3,
        arg4,
        arg5,
        arg6,
        arg7,
        arg8,
        arg9,
        arg10,
        arg11,
        arg12,
        arg13);

        Assert.Equal(default, result);

        Assert.Equal(arg1, [1]);
        Assert.Equal(arg2, [2]);
        Assert.Equal(arg3, [3]);
        Assert.Equal(arg4, [4]);
        Assert.Equal(arg5, [5]);
        Assert.Equal(arg6, [6]);
        Assert.Equal(arg7, [7]);
        Assert.Equal(arg8, [8]);
        Assert.Equal(arg9, [9]);
        Assert.Equal(arg10, [10]);
        Assert.Equal(arg11, [11]);
        Assert.Equal(arg12, [12]);
        Assert.Equal(arg13, [13]);
    }

    [Fact]
    public static void InvokeRefStruct_14_ExpectSuccess()
    {
        var arg1 = AllocateArg();
        var arg2 = AllocateArg();
        var arg3 = AllocateArg();
        var arg4 = AllocateArg();
        var arg5 = AllocateArg();
        var arg6 = AllocateArg();
        var arg7 = AllocateArg();
        var arg8 = AllocateArg();
        var arg9 = AllocateArg();
        var arg10 = AllocateArg();
        var arg11 = AllocateArg();
        var arg12 = AllocateArg();
        var arg13 = AllocateArg();
        var arg14 = AllocateArg();

        var result = Unit.Invoke((
            arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6,
            arg7,
            arg8,
            arg9,
            arg10,
            arg11,
            arg12,
            arg13,
            arg14) =>
        {
            FillArg(arg1, 1);
            FillArg(arg2, 2);
            FillArg(arg3, 3);
            FillArg(arg4, 4);
            FillArg(arg5, 5);
            FillArg(arg6, 6);
            FillArg(arg7, 7);
            FillArg(arg8, 8);
            FillArg(arg9, 9);
            FillArg(arg10, 10);
            FillArg(arg11, 11);
            FillArg(arg12, 12);
            FillArg(arg13, 13);
            FillArg(arg14, 14);
        },
        arg1,
        arg2,
        arg3,
        arg4,
        arg5,
        arg6,
        arg7,
        arg8,
        arg9,
        arg10,
        arg11,
        arg12,
        arg13,
        arg14);

        Assert.Equal(default, result);

        Assert.Equal(arg1, [1]);
        Assert.Equal(arg2, [2]);
        Assert.Equal(arg3, [3]);
        Assert.Equal(arg4, [4]);
        Assert.Equal(arg5, [5]);
        Assert.Equal(arg6, [6]);
        Assert.Equal(arg7, [7]);
        Assert.Equal(arg8, [8]);
        Assert.Equal(arg9, [9]);
        Assert.Equal(arg10, [10]);
        Assert.Equal(arg11, [11]);
        Assert.Equal(arg12, [12]);
        Assert.Equal(arg13, [13]);
        Assert.Equal(arg14, [14]);
    }

    [Fact]
    public static void InvokeRefStruct_15_ExpectSuccess()
    {
        var arg1 = AllocateArg();
        var arg2 = AllocateArg();
        var arg3 = AllocateArg();
        var arg4 = AllocateArg();
        var arg5 = AllocateArg();
        var arg6 = AllocateArg();
        var arg7 = AllocateArg();
        var arg8 = AllocateArg();
        var arg9 = AllocateArg();
        var arg10 = AllocateArg();
        var arg11 = AllocateArg();
        var arg12 = AllocateArg();
        var arg13 = AllocateArg();
        var arg14 = AllocateArg();
        var arg15 = AllocateArg();

        var result = Unit.Invoke((
            arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6,
            arg7,
            arg8,
            arg9,
            arg10,
            arg11,
            arg12,
            arg13,
            arg14,
            arg15) =>
        {
            FillArg(arg1, 1);
            FillArg(arg2, 2);
            FillArg(arg3, 3);
            FillArg(arg4, 4);
            FillArg(arg5, 5);
            FillArg(arg6, 6);
            FillArg(arg7, 7);
            FillArg(arg8, 8);
            FillArg(arg9, 9);
            FillArg(arg10, 10);
            FillArg(arg11, 11);
            FillArg(arg12, 12);
            FillArg(arg13, 13);
            FillArg(arg14, 14);
            FillArg(arg15, 15);
        },
        arg1,
        arg2,
        arg3,
        arg4,
        arg5,
        arg6,
        arg7,
        arg8,
        arg9,
        arg10,
        arg11,
        arg12,
        arg13,
        arg14,
        arg15);

        Assert.Equal(default, result);

        Assert.Equal(arg1, [1]);
        Assert.Equal(arg2, [2]);
        Assert.Equal(arg3, [3]);
        Assert.Equal(arg4, [4]);
        Assert.Equal(arg5, [5]);
        Assert.Equal(arg6, [6]);
        Assert.Equal(arg7, [7]);
        Assert.Equal(arg8, [8]);
        Assert.Equal(arg9, [9]);
        Assert.Equal(arg10, [10]);
        Assert.Equal(arg11, [11]);
        Assert.Equal(arg12, [12]);
        Assert.Equal(arg13, [13]);
        Assert.Equal(arg14, [14]);
        Assert.Equal(arg15, [15]);
    }

    [Fact]
    public static void InvokeRefStruct_16_ExpectSuccess()
    {
        var arg1 = AllocateArg();
        var arg2 = AllocateArg();
        var arg3 = AllocateArg();
        var arg4 = AllocateArg();
        var arg5 = AllocateArg();
        var arg6 = AllocateArg();
        var arg7 = AllocateArg();
        var arg8 = AllocateArg();
        var arg9 = AllocateArg();
        var arg10 = AllocateArg();
        var arg11 = AllocateArg();
        var arg12 = AllocateArg();
        var arg13 = AllocateArg();
        var arg14 = AllocateArg();
        var arg15 = AllocateArg();
        var arg16 = AllocateArg();

        var result = Unit.Invoke((
            arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6,
            arg7,
            arg8,
            arg9,
            arg10,
            arg11,
            arg12,
            arg13,
            arg14,
            arg15,
            arg16) =>
        {
            FillArg(arg1, 1);
            FillArg(arg2, 2);
            FillArg(arg3, 3);
            FillArg(arg4, 4);
            FillArg(arg5, 5);
            FillArg(arg6, 6);
            FillArg(arg7, 7);
            FillArg(arg8, 8);
            FillArg(arg9, 9);
            FillArg(arg10, 10);
            FillArg(arg11, 11);
            FillArg(arg12, 12);
            FillArg(arg13, 13);
            FillArg(arg14, 14);
            FillArg(arg15, 15);
            FillArg(arg16, 16);
        },
        arg1,
        arg2,
        arg3,
        arg4,
        arg5,
        arg6,
        arg7,
        arg8,
        arg9,
        arg10,
        arg11,
        arg12,
        arg13,
        arg14,
        arg15,
        arg16);

        Assert.Equal(default, result);

        Assert.Equal(arg1, [1]);
        Assert.Equal(arg2, [2]);
        Assert.Equal(arg3, [3]);
        Assert.Equal(arg4, [4]);
        Assert.Equal(arg5, [5]);
        Assert.Equal(arg6, [6]);
        Assert.Equal(arg7, [7]);
        Assert.Equal(arg8, [8]);
        Assert.Equal(arg9, [9]);
        Assert.Equal(arg10, [10]);
        Assert.Equal(arg11, [11]);
        Assert.Equal(arg12, [12]);
        Assert.Equal(arg13, [13]);
        Assert.Equal(arg14, [14]);
        Assert.Equal(arg15, [15]);
        Assert.Equal(arg16, [16]);
    }

    private static Span<int> AllocateArg() => new int[1];

    private static void FillArg(Span<int> arg, int argNumber)
    {
        Debug.Assert(arg.Length == 1);
        Debug.Assert(argNumber >= 1 && argNumber <= 16);
        arg[0] = argNumber;
    }
}

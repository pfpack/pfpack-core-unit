using System;
using System.Diagnostics;
using Xunit;

namespace PrimeFuncPack.Core.Tests;

public static class UnitExtensionsInvokeAsFuncRefStructTests
{
    [Fact]
    public static void InvokeAsFuncRefStruct_01_ExpectSuccess()
    {
        var arg = AllocateArg();

        var action = (Span<int> arg) => FillArg(arg, 1);
        var result = action.InvokeAsFunc(arg);

        Assert.Equal(default, result);
        Assert.Equal(arg, [1]);
    }

    [Fact]
    public static void InvokeAsFuncRefStruct_02_ExpectSuccess()
    {
        var arg1 = AllocateArg();
        var arg2 = AllocateArg();

        var action = (
            Span<int> arg1,
            Span<int> arg2) =>
        {
            FillArg(arg1, 1);
            FillArg(arg2, 2);
        };

        var result = action.InvokeAsFunc(
            arg1,
            arg2);

        Assert.Equal(default, result);

        Assert.Equal(arg1, [1]);
        Assert.Equal(arg2, [2]);
    }

    [Fact]
    public static void InvokeAsFuncRefStruct_03_ExpectSuccess()
    {
        var arg1 = AllocateArg();
        var arg2 = AllocateArg();
        var arg3 = AllocateArg();

        var action = (
            Span<int> arg1,
            Span<int> arg2,
            Span<int> arg3) =>
        {
            FillArg(arg1, 1);
            FillArg(arg2, 2);
            FillArg(arg3, 3);
        };

        var result = action.InvokeAsFunc(
            arg1,
            arg2,
            arg3);

        Assert.Equal(default, result);

        Assert.Equal(arg1, [1]);
        Assert.Equal(arg2, [2]);
        Assert.Equal(arg3, [3]);
    }

    [Fact]
    public static void InvokeAsFuncRefStruct_04_ExpectSuccess()
    {
        var arg1 = AllocateArg();
        var arg2 = AllocateArg();
        var arg3 = AllocateArg();
        var arg4 = AllocateArg();

        var action = (
            Span<int> arg1,
            Span<int> arg2,
            Span<int> arg3,
            Span<int> arg4) =>
        {
            FillArg(arg1, 1);
            FillArg(arg2, 2);
            FillArg(arg3, 3);
            FillArg(arg4, 4);
        };

        var result = action.InvokeAsFunc(
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
    public static void InvokeAsFuncRefStruct_05_ExpectSuccess()
    {
        var arg1 = AllocateArg();
        var arg2 = AllocateArg();
        var arg3 = AllocateArg();
        var arg4 = AllocateArg();
        var arg5 = AllocateArg();

        var action = (
            Span<int> arg1,
            Span<int> arg2,
            Span<int> arg3,
            Span<int> arg4,
            Span<int> arg5) =>
        {
            FillArg(arg1, 1);
            FillArg(arg2, 2);
            FillArg(arg3, 3);
            FillArg(arg4, 4);
            FillArg(arg5, 5);
        };

        var result = action.InvokeAsFunc(
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
    public static void InvokeAsFuncRefStruct_06_ExpectSuccess()
    {
        var arg1 = AllocateArg();
        var arg2 = AllocateArg();
        var arg3 = AllocateArg();
        var arg4 = AllocateArg();
        var arg5 = AllocateArg();
        var arg6 = AllocateArg();

        var action = (
            Span<int> arg1,
            Span<int> arg2,
            Span<int> arg3,
            Span<int> arg4,
            Span<int> arg5,
            Span<int> arg6) =>
        {
            FillArg(arg1, 1);
            FillArg(arg2, 2);
            FillArg(arg3, 3);
            FillArg(arg4, 4);
            FillArg(arg5, 5);
            FillArg(arg6, 6);
        };

        var result = action.InvokeAsFunc(
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
    public static void InvokeAsFuncRefStruct_07_ExpectSuccess()
    {
        var arg1 = AllocateArg();
        var arg2 = AllocateArg();
        var arg3 = AllocateArg();
        var arg4 = AllocateArg();
        var arg5 = AllocateArg();
        var arg6 = AllocateArg();
        var arg7 = AllocateArg();

        var action = (
            Span<int> arg1,
            Span<int> arg2,
            Span<int> arg3,
            Span<int> arg4,
            Span<int> arg5,
            Span<int> arg6,
            Span<int> arg7) =>
        {
            FillArg(arg1, 1);
            FillArg(arg2, 2);
            FillArg(arg3, 3);
            FillArg(arg4, 4);
            FillArg(arg5, 5);
            FillArg(arg6, 6);
            FillArg(arg7, 7);
        };

        var result = action.InvokeAsFunc(
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
    public static void InvokeAsFuncRefStruct_08_ExpectSuccess()
    {
        var arg1 = AllocateArg();
        var arg2 = AllocateArg();
        var arg3 = AllocateArg();
        var arg4 = AllocateArg();
        var arg5 = AllocateArg();
        var arg6 = AllocateArg();
        var arg7 = AllocateArg();
        var arg8 = AllocateArg();

        var action = (
            Span<int> arg1,
            Span<int> arg2,
            Span<int> arg3,
            Span<int> arg4,
            Span<int> arg5,
            Span<int> arg6,
            Span<int> arg7,
            Span<int> arg8) =>
        {
            FillArg(arg1, 1);
            FillArg(arg2, 2);
            FillArg(arg3, 3);
            FillArg(arg4, 4);
            FillArg(arg5, 5);
            FillArg(arg6, 6);
            FillArg(arg7, 7);
            FillArg(arg8, 8);
        };

        var result = action.InvokeAsFunc(
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
    public static void InvokeAsFuncRefStruct_09_ExpectSuccess()
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

        var action = (
            Span<int> arg1,
            Span<int> arg2,
            Span<int> arg3,
            Span<int> arg4,
            Span<int> arg5,
            Span<int> arg6,
            Span<int> arg7,
            Span<int> arg8,
            Span<int> arg9) =>
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
        };

        var result = action.InvokeAsFunc(
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
    public static void InvokeAsFuncRefStruct_10_ExpectSuccess()
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

        var action = (
            Span<int> arg1,
            Span<int> arg2,
            Span<int> arg3,
            Span<int> arg4,
            Span<int> arg5,
            Span<int> arg6,
            Span<int> arg7,
            Span<int> arg8,
            Span<int> arg9,
            Span<int> arg10) =>
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
        };

        var result = action.InvokeAsFunc(
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
    public static void InvokeAsFuncRefStruct_11_ExpectSuccess()
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

        var action = (
            Span<int> arg1,
            Span<int> arg2,
            Span<int> arg3,
            Span<int> arg4,
            Span<int> arg5,
            Span<int> arg6,
            Span<int> arg7,
            Span<int> arg8,
            Span<int> arg9,
            Span<int> arg10,
            Span<int> arg11) =>
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
        };

        var result = action.InvokeAsFunc(
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
    public static void InvokeAsFuncRefStruct_12_ExpectSuccess()
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

        var action = (
            Span<int> arg1,
            Span<int> arg2,
            Span<int> arg3,
            Span<int> arg4,
            Span<int> arg5,
            Span<int> arg6,
            Span<int> arg7,
            Span<int> arg8,
            Span<int> arg9,
            Span<int> arg10,
            Span<int> arg11,
            Span<int> arg12) =>
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
        };

        var result = action.InvokeAsFunc(
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
    public static void InvokeAsFuncRefStruct_13_ExpectSuccess()
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

        var action = (
            Span<int> arg1,
            Span<int> arg2,
            Span<int> arg3,
            Span<int> arg4,
            Span<int> arg5,
            Span<int> arg6,
            Span<int> arg7,
            Span<int> arg8,
            Span<int> arg9,
            Span<int> arg10,
            Span<int> arg11,
            Span<int> arg12,
            Span<int> arg13) =>
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
        };

        var result = action.InvokeAsFunc(
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
    public static void InvokeAsFuncRefStruct_14_ExpectSuccess()
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

        var action = (
            Span<int> arg1,
            Span<int> arg2,
            Span<int> arg3,
            Span<int> arg4,
            Span<int> arg5,
            Span<int> arg6,
            Span<int> arg7,
            Span<int> arg8,
            Span<int> arg9,
            Span<int> arg10,
            Span<int> arg11,
            Span<int> arg12,
            Span<int> arg13,
            Span<int> arg14) =>
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
        };

        var result = action.InvokeAsFunc(
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
    public static void InvokeAsFuncRefStruct_15_ExpectSuccess()
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

        var action = (
            Span<int> arg1,
            Span<int> arg2,
            Span<int> arg3,
            Span<int> arg4,
            Span<int> arg5,
            Span<int> arg6,
            Span<int> arg7,
            Span<int> arg8,
            Span<int> arg9,
            Span<int> arg10,
            Span<int> arg11,
            Span<int> arg12,
            Span<int> arg13,
            Span<int> arg14,
            Span<int> arg15) =>
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
        };

        var result = action.InvokeAsFunc(
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
    public static void InvokeAsFuncRefStruct_16_ExpectSuccess()
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

        var action = (
            Span<int> arg1,
            Span<int> arg2,
            Span<int> arg3,
            Span<int> arg4,
            Span<int> arg5,
            Span<int> arg6,
            Span<int> arg7,
            Span<int> arg8,
            Span<int> arg9,
            Span<int> arg10,
            Span<int> arg11,
            Span<int> arg12,
            Span<int> arg13,
            Span<int> arg14,
            Span<int> arg15,
            Span<int> arg16) =>
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
        };

        var result = action.InvokeAsFunc(
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

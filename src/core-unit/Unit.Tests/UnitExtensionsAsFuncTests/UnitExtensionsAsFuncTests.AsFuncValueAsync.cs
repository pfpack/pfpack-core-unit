using System;
using System.Threading.Tasks;
using Xunit;

namespace PrimeFuncPack.Core.Tests;

partial class UnitExtensionsAsFuncTests
{
    [Fact]
    public static async Task AsFuncValueAsync00_ExpectInvoked()
    {
        var isInvoked = false;

        var actionAsync = ActionMethodAsync;
        var unit = await actionAsync.AsFuncValueAsync().Invoke();

        AssertHelper.AssertDefault(in unit);
        Assert.True(isInvoked);

        async ValueTask ActionMethodAsync()
        {
            isInvoked = true;
        }
    }

    [Fact]
    public static async Task AsFuncValueAsync01_ExpectInvoked()
    {
        var param1 = new ActionParam1();

        var actionAsync = ActionMethodAsync;
        var unit = await actionAsync.AsFuncValueAsync().Invoke(
            param1);

        AssertHelper.AssertDefault(in unit);
        Assert.True(param1.IsInvoked);

        static async ValueTask ActionMethodAsync(
            ActionParam1 param1)
        {
            param1.IsInvoked = true;
        }
    }

    [Fact]
    public static async Task AsFuncValueAsync02_ExpectInvoked()
    {
        var param1 = new ActionParam1();
        var param2 = new ActionParam2();

        var actionAsync = ActionMethodAsync;
        var unit = await actionAsync.AsFuncValueAsync().Invoke(
            param1,
            param2);

        AssertHelper.AssertDefault(in unit);
        Assert.True(param1.IsInvoked);
        Assert.True(param2.IsInvoked);

        static async ValueTask ActionMethodAsync(
            ActionParam1 param1,
            ActionParam2 param2)
        {
            param1.IsInvoked = true;
            param2.IsInvoked = true;
        }
    }

    [Fact]
    public static async Task AsFuncValueAsync03_ExpectInvoked()
    {
        var param1 = new ActionParam1();
        var param2 = new ActionParam2();
        var param3 = new ActionParam3();

        var actionAsync = ActionMethodAsync;
        var unit = await actionAsync.AsFuncValueAsync().Invoke(
            param1,
            param2,
            param3);

        AssertHelper.AssertDefault(in unit);
        Assert.True(param1.IsInvoked);
        Assert.True(param2.IsInvoked);
        Assert.True(param3.IsInvoked);

        static async ValueTask ActionMethodAsync(
            ActionParam1 param1,
            ActionParam2 param2,
            ActionParam3 param3)
        {
            param1.IsInvoked = true;
            param2.IsInvoked = true;
            param3.IsInvoked = true;
        }
    }

    [Fact]
    public static async Task AsFuncValueAsync04_ExpectInvoked()
    {
        var param1 = new ActionParam1();
        var param2 = new ActionParam2();
        var param3 = new ActionParam3();
        var param4 = new ActionParam4();

        var actionAsync = ActionMethodAsync;
        var unit = await actionAsync.AsFuncValueAsync().Invoke(
            param1,
            param2,
            param3,
            param4);

        AssertHelper.AssertDefault(in unit);
        Assert.True(param1.IsInvoked);
        Assert.True(param2.IsInvoked);
        Assert.True(param3.IsInvoked);
        Assert.True(param4.IsInvoked);

        static async ValueTask ActionMethodAsync(
            ActionParam1 param1,
            ActionParam2 param2,
            ActionParam3 param3,
            ActionParam4 param4)
        {
            param1.IsInvoked = true;
            param2.IsInvoked = true;
            param3.IsInvoked = true;
            param4.IsInvoked = true;
        }
    }

    [Fact]
    public static async Task AsFuncValueAsync05_ExpectInvoked()
    {
        var param1 = new ActionParam1();
        var param2 = new ActionParam2();
        var param3 = new ActionParam3();
        var param4 = new ActionParam4();
        var param5 = new ActionParam5();

        var actionAsync = ActionMethodAsync;
        var unit = await actionAsync.AsFuncValueAsync().Invoke(
            param1,
            param2,
            param3,
            param4,
            param5);

        AssertHelper.AssertDefault(in unit);
        Assert.True(param1.IsInvoked);
        Assert.True(param2.IsInvoked);
        Assert.True(param3.IsInvoked);
        Assert.True(param4.IsInvoked);
        Assert.True(param5.IsInvoked);

        static async ValueTask ActionMethodAsync(
            ActionParam1 param1,
            ActionParam2 param2,
            ActionParam3 param3,
            ActionParam4 param4,
            ActionParam5 param5)
        {
            param1.IsInvoked = true;
            param2.IsInvoked = true;
            param3.IsInvoked = true;
            param4.IsInvoked = true;
            param5.IsInvoked = true;
        }
    }

    [Fact]
    public static async Task AsFuncValueAsync06_ExpectInvoked()
    {
        var param1 = new ActionParam1();
        var param2 = new ActionParam2();
        var param3 = new ActionParam3();
        var param4 = new ActionParam4();
        var param5 = new ActionParam5();
        var param6 = new ActionParam6();

        var actionAsync = ActionMethodAsync;
        var unit = await actionAsync.AsFuncValueAsync().Invoke(
            param1,
            param2,
            param3,
            param4,
            param5,
            param6);

        AssertHelper.AssertDefault(in unit);
        Assert.True(param1.IsInvoked);
        Assert.True(param2.IsInvoked);
        Assert.True(param3.IsInvoked);
        Assert.True(param4.IsInvoked);
        Assert.True(param5.IsInvoked);
        Assert.True(param6.IsInvoked);

        static async ValueTask ActionMethodAsync(
            ActionParam1 param1,
            ActionParam2 param2,
            ActionParam3 param3,
            ActionParam4 param4,
            ActionParam5 param5,
            ActionParam6 param6)
        {
            param1.IsInvoked = true;
            param2.IsInvoked = true;
            param3.IsInvoked = true;
            param4.IsInvoked = true;
            param5.IsInvoked = true;
            param6.IsInvoked = true;
        }
    }

    [Fact]
    public static async Task AsFuncValueAsync07_ExpectInvoked()
    {
        var param1 = new ActionParam1();
        var param2 = new ActionParam2();
        var param3 = new ActionParam3();
        var param4 = new ActionParam4();
        var param5 = new ActionParam5();
        var param6 = new ActionParam6();
        var param7 = new ActionParam7();

        var actionAsync = ActionMethodAsync;
        var unit = await actionAsync.AsFuncValueAsync().Invoke(
            param1,
            param2,
            param3,
            param4,
            param5,
            param6,
            param7);

        AssertHelper.AssertDefault(in unit);
        Assert.True(param1.IsInvoked);
        Assert.True(param2.IsInvoked);
        Assert.True(param3.IsInvoked);
        Assert.True(param4.IsInvoked);
        Assert.True(param5.IsInvoked);
        Assert.True(param6.IsInvoked);
        Assert.True(param7.IsInvoked);

        static async ValueTask ActionMethodAsync(
            ActionParam1 param1,
            ActionParam2 param2,
            ActionParam3 param3,
            ActionParam4 param4,
            ActionParam5 param5,
            ActionParam6 param6,
            ActionParam7 param7)
        {
            param1.IsInvoked = true;
            param2.IsInvoked = true;
            param3.IsInvoked = true;
            param4.IsInvoked = true;
            param5.IsInvoked = true;
            param6.IsInvoked = true;
            param7.IsInvoked = true;
        }
    }


    [Fact]
    public static async Task AsFuncValueAsync08_ExpectInvoked()
    {
        var param1 = new ActionParam1();
        var param2 = new ActionParam2();
        var param3 = new ActionParam3();
        var param4 = new ActionParam4();
        var param5 = new ActionParam5();
        var param6 = new ActionParam6();
        var param7 = new ActionParam7();
        var param8 = new ActionParam8();

        var actionAsync = ActionMethodAsync;
        var unit = await actionAsync.AsFuncValueAsync().Invoke(
            param1,
            param2,
            param3,
            param4,
            param5,
            param6,
            param7,
            param8);

        AssertHelper.AssertDefault(in unit);
        Assert.True(param1.IsInvoked);
        Assert.True(param2.IsInvoked);
        Assert.True(param3.IsInvoked);
        Assert.True(param4.IsInvoked);
        Assert.True(param5.IsInvoked);
        Assert.True(param6.IsInvoked);
        Assert.True(param7.IsInvoked);
        Assert.True(param8.IsInvoked);

        static async ValueTask ActionMethodAsync(
            ActionParam1 param1,
            ActionParam2 param2,
            ActionParam3 param3,
            ActionParam4 param4,
            ActionParam5 param5,
            ActionParam6 param6,
            ActionParam7 param7,
            ActionParam8 param8)
        {
            param1.IsInvoked = true;
            param2.IsInvoked = true;
            param3.IsInvoked = true;
            param4.IsInvoked = true;
            param5.IsInvoked = true;
            param6.IsInvoked = true;
            param7.IsInvoked = true;
            param8.IsInvoked = true;
        }
    }

    [Fact]
    public static async Task AsFuncValueAsync09_ExpectInvoked()
    {
        var param1 = new ActionParam1();
        var param2 = new ActionParam2();
        var param3 = new ActionParam3();
        var param4 = new ActionParam4();
        var param5 = new ActionParam5();
        var param6 = new ActionParam6();
        var param7 = new ActionParam7();
        var param8 = new ActionParam8();
        var param9 = new ActionParam9();

        var actionAsync = ActionMethodAsync;
        var unit = await actionAsync.AsFuncValueAsync().Invoke(
            param1,
            param2,
            param3,
            param4,
            param5,
            param6,
            param7,
            param8,
            param9);

        AssertHelper.AssertDefault(in unit);
        Assert.True(param1.IsInvoked);
        Assert.True(param2.IsInvoked);
        Assert.True(param3.IsInvoked);
        Assert.True(param4.IsInvoked);
        Assert.True(param5.IsInvoked);
        Assert.True(param6.IsInvoked);
        Assert.True(param7.IsInvoked);
        Assert.True(param8.IsInvoked);
        Assert.True(param9.IsInvoked);

        static async ValueTask ActionMethodAsync(
            ActionParam1 param1,
            ActionParam2 param2,
            ActionParam3 param3,
            ActionParam4 param4,
            ActionParam5 param5,
            ActionParam6 param6,
            ActionParam7 param7,
            ActionParam8 param8,
            ActionParam9 param9)
        {
            param1.IsInvoked = true;
            param2.IsInvoked = true;
            param3.IsInvoked = true;
            param4.IsInvoked = true;
            param5.IsInvoked = true;
            param6.IsInvoked = true;
            param7.IsInvoked = true;
            param8.IsInvoked = true;
            param9.IsInvoked = true;
        }
    }

    [Fact]
    public static async Task AsFuncValueAsync10_ExpectInvoked()
    {
        var param1 = new ActionParam1();
        var param2 = new ActionParam2();
        var param3 = new ActionParam3();
        var param4 = new ActionParam4();
        var param5 = new ActionParam5();
        var param6 = new ActionParam6();
        var param7 = new ActionParam7();
        var param8 = new ActionParam8();
        var param9 = new ActionParam9();
        var param10 = new ActionParam10();

        var actionAsync = ActionMethodAsync;
        var unit = await actionAsync.AsFuncValueAsync().Invoke(
            param1,
            param2,
            param3,
            param4,
            param5,
            param6,
            param7,
            param8,
            param9,
            param10);

        AssertHelper.AssertDefault(in unit);
        Assert.True(param1.IsInvoked);
        Assert.True(param2.IsInvoked);
        Assert.True(param3.IsInvoked);
        Assert.True(param4.IsInvoked);
        Assert.True(param5.IsInvoked);
        Assert.True(param6.IsInvoked);
        Assert.True(param7.IsInvoked);
        Assert.True(param8.IsInvoked);
        Assert.True(param9.IsInvoked);
        Assert.True(param10.IsInvoked);

        static async ValueTask ActionMethodAsync(
            ActionParam1 param1,
            ActionParam2 param2,
            ActionParam3 param3,
            ActionParam4 param4,
            ActionParam5 param5,
            ActionParam6 param6,
            ActionParam7 param7,
            ActionParam8 param8,
            ActionParam9 param9,
            ActionParam10 param10)
        {
            param1.IsInvoked = true;
            param2.IsInvoked = true;
            param3.IsInvoked = true;
            param4.IsInvoked = true;
            param5.IsInvoked = true;
            param6.IsInvoked = true;
            param7.IsInvoked = true;
            param8.IsInvoked = true;
            param9.IsInvoked = true;
            param10.IsInvoked = true;
        }
    }


    [Fact]
    public static async Task AsFuncValueAsync11_ExpectInvoked()
    {
        var param1 = new ActionParam1();
        var param2 = new ActionParam2();
        var param3 = new ActionParam3();
        var param4 = new ActionParam4();
        var param5 = new ActionParam5();
        var param6 = new ActionParam6();
        var param7 = new ActionParam7();
        var param8 = new ActionParam8();
        var param9 = new ActionParam9();
        var param10 = new ActionParam10();
        var param11 = new ActionParam11();

        var actionAsync = ActionMethodAsync;
        var unit = await actionAsync.AsFuncValueAsync().Invoke(
            param1,
            param2,
            param3,
            param4,
            param5,
            param6,
            param7,
            param8,
            param9,
            param10,
            param11);

        AssertHelper.AssertDefault(in unit);
        Assert.True(param1.IsInvoked);
        Assert.True(param2.IsInvoked);
        Assert.True(param3.IsInvoked);
        Assert.True(param4.IsInvoked);
        Assert.True(param5.IsInvoked);
        Assert.True(param6.IsInvoked);
        Assert.True(param7.IsInvoked);
        Assert.True(param8.IsInvoked);
        Assert.True(param9.IsInvoked);
        Assert.True(param10.IsInvoked);
        Assert.True(param11.IsInvoked);

        static async ValueTask ActionMethodAsync(
            ActionParam1 param1,
            ActionParam2 param2,
            ActionParam3 param3,
            ActionParam4 param4,
            ActionParam5 param5,
            ActionParam6 param6,
            ActionParam7 param7,
            ActionParam8 param8,
            ActionParam9 param9,
            ActionParam10 param10,
            ActionParam11 param11)
        {
            param1.IsInvoked = true;
            param2.IsInvoked = true;
            param3.IsInvoked = true;
            param4.IsInvoked = true;
            param5.IsInvoked = true;
            param6.IsInvoked = true;
            param7.IsInvoked = true;
            param8.IsInvoked = true;
            param9.IsInvoked = true;
            param10.IsInvoked = true;
            param11.IsInvoked = true;
        }
    }

    [Fact]
    public static async Task AsFuncValueAsync12_ExpectInvoked()
    {
        var param1 = new ActionParam1();
        var param2 = new ActionParam2();
        var param3 = new ActionParam3();
        var param4 = new ActionParam4();
        var param5 = new ActionParam5();
        var param6 = new ActionParam6();
        var param7 = new ActionParam7();
        var param8 = new ActionParam8();
        var param9 = new ActionParam9();
        var param10 = new ActionParam10();
        var param11 = new ActionParam11();
        var param12 = new ActionParam12();

        var actionAsync = ActionMethodAsync;
        var unit = await actionAsync.AsFuncValueAsync().Invoke(
            param1,
            param2,
            param3,
            param4,
            param5,
            param6,
            param7,
            param8,
            param9,
            param10,
            param11,
            param12);

        AssertHelper.AssertDefault(in unit);
        Assert.True(param1.IsInvoked);
        Assert.True(param2.IsInvoked);
        Assert.True(param3.IsInvoked);
        Assert.True(param4.IsInvoked);
        Assert.True(param5.IsInvoked);
        Assert.True(param6.IsInvoked);
        Assert.True(param7.IsInvoked);
        Assert.True(param8.IsInvoked);
        Assert.True(param9.IsInvoked);
        Assert.True(param10.IsInvoked);
        Assert.True(param11.IsInvoked);
        Assert.True(param12.IsInvoked);

        static async ValueTask ActionMethodAsync(
            ActionParam1 param1,
            ActionParam2 param2,
            ActionParam3 param3,
            ActionParam4 param4,
            ActionParam5 param5,
            ActionParam6 param6,
            ActionParam7 param7,
            ActionParam8 param8,
            ActionParam9 param9,
            ActionParam10 param10,
            ActionParam11 param11,
            ActionParam12 param12)
        {
            param1.IsInvoked = true;
            param2.IsInvoked = true;
            param3.IsInvoked = true;
            param4.IsInvoked = true;
            param5.IsInvoked = true;
            param6.IsInvoked = true;
            param7.IsInvoked = true;
            param8.IsInvoked = true;
            param9.IsInvoked = true;
            param10.IsInvoked = true;
            param11.IsInvoked = true;
            param12.IsInvoked = true;
        }
    }

    [Fact]
    public static async Task AsFuncValueAsync13_ExpectInvoked()
    {
        var param1 = new ActionParam1();
        var param2 = new ActionParam2();
        var param3 = new ActionParam3();
        var param4 = new ActionParam4();
        var param5 = new ActionParam5();
        var param6 = new ActionParam6();
        var param7 = new ActionParam7();
        var param8 = new ActionParam8();
        var param9 = new ActionParam9();
        var param10 = new ActionParam10();
        var param11 = new ActionParam11();
        var param12 = new ActionParam12();
        var param13 = new ActionParam13();

        var actionAsync = ActionMethodAsync;
        var unit = await actionAsync.AsFuncValueAsync().Invoke(
            param1,
            param2,
            param3,
            param4,
            param5,
            param6,
            param7,
            param8,
            param9,
            param10,
            param11,
            param12,
            param13);

        AssertHelper.AssertDefault(in unit);
        Assert.True(param1.IsInvoked);
        Assert.True(param2.IsInvoked);
        Assert.True(param3.IsInvoked);
        Assert.True(param4.IsInvoked);
        Assert.True(param5.IsInvoked);
        Assert.True(param6.IsInvoked);
        Assert.True(param7.IsInvoked);
        Assert.True(param8.IsInvoked);
        Assert.True(param9.IsInvoked);
        Assert.True(param10.IsInvoked);
        Assert.True(param11.IsInvoked);
        Assert.True(param12.IsInvoked);
        Assert.True(param13.IsInvoked);

        static async ValueTask ActionMethodAsync(
            ActionParam1 param1,
            ActionParam2 param2,
            ActionParam3 param3,
            ActionParam4 param4,
            ActionParam5 param5,
            ActionParam6 param6,
            ActionParam7 param7,
            ActionParam8 param8,
            ActionParam9 param9,
            ActionParam10 param10,
            ActionParam11 param11,
            ActionParam12 param12,
            ActionParam13 param13)
        {
            param1.IsInvoked = true;
            param2.IsInvoked = true;
            param3.IsInvoked = true;
            param4.IsInvoked = true;
            param5.IsInvoked = true;
            param6.IsInvoked = true;
            param7.IsInvoked = true;
            param8.IsInvoked = true;
            param9.IsInvoked = true;
            param10.IsInvoked = true;
            param11.IsInvoked = true;
            param12.IsInvoked = true;
            param13.IsInvoked = true;
        }
    }


    [Fact]
    public static async Task AsFuncValueAsync14_ExpectInvoked()
    {
        var param1 = new ActionParam1();
        var param2 = new ActionParam2();
        var param3 = new ActionParam3();
        var param4 = new ActionParam4();
        var param5 = new ActionParam5();
        var param6 = new ActionParam6();
        var param7 = new ActionParam7();
        var param8 = new ActionParam8();
        var param9 = new ActionParam9();
        var param10 = new ActionParam10();
        var param11 = new ActionParam11();
        var param12 = new ActionParam12();
        var param13 = new ActionParam13();
        var param14 = new ActionParam14();

        var actionAsync = ActionMethodAsync;
        var unit = await actionAsync.AsFuncValueAsync().Invoke(
            param1,
            param2,
            param3,
            param4,
            param5,
            param6,
            param7,
            param8,
            param9,
            param10,
            param11,
            param12,
            param13,
            param14);

        AssertHelper.AssertDefault(in unit);
        Assert.True(param1.IsInvoked);
        Assert.True(param2.IsInvoked);
        Assert.True(param3.IsInvoked);
        Assert.True(param4.IsInvoked);
        Assert.True(param5.IsInvoked);
        Assert.True(param6.IsInvoked);
        Assert.True(param7.IsInvoked);
        Assert.True(param8.IsInvoked);
        Assert.True(param9.IsInvoked);
        Assert.True(param10.IsInvoked);
        Assert.True(param11.IsInvoked);
        Assert.True(param12.IsInvoked);
        Assert.True(param13.IsInvoked);
        Assert.True(param14.IsInvoked);

        static async ValueTask ActionMethodAsync(
            ActionParam1 param1,
            ActionParam2 param2,
            ActionParam3 param3,
            ActionParam4 param4,
            ActionParam5 param5,
            ActionParam6 param6,
            ActionParam7 param7,
            ActionParam8 param8,
            ActionParam9 param9,
            ActionParam10 param10,
            ActionParam11 param11,
            ActionParam12 param12,
            ActionParam13 param13,
            ActionParam14 param14)
        {
            param1.IsInvoked = true;
            param2.IsInvoked = true;
            param3.IsInvoked = true;
            param4.IsInvoked = true;
            param5.IsInvoked = true;
            param6.IsInvoked = true;
            param7.IsInvoked = true;
            param8.IsInvoked = true;
            param9.IsInvoked = true;
            param10.IsInvoked = true;
            param11.IsInvoked = true;
            param12.IsInvoked = true;
            param13.IsInvoked = true;
            param14.IsInvoked = true;
        }
    }

    [Fact]
    public static async Task AsFuncValueAsync15_ExpectInvoked()
    {
        var param1 = new ActionParam1();
        var param2 = new ActionParam2();
        var param3 = new ActionParam3();
        var param4 = new ActionParam4();
        var param5 = new ActionParam5();
        var param6 = new ActionParam6();
        var param7 = new ActionParam7();
        var param8 = new ActionParam8();
        var param9 = new ActionParam9();
        var param10 = new ActionParam10();
        var param11 = new ActionParam11();
        var param12 = new ActionParam12();
        var param13 = new ActionParam13();
        var param14 = new ActionParam14();
        var param15 = new ActionParam15();

        var actionAsync = ActionMethodAsync;
        var unit = await actionAsync.AsFuncValueAsync().Invoke(
            param1,
            param2,
            param3,
            param4,
            param5,
            param6,
            param7,
            param8,
            param9,
            param10,
            param11,
            param12,
            param13,
            param14,
            param15);

        AssertHelper.AssertDefault(in unit);
        Assert.True(param1.IsInvoked);
        Assert.True(param2.IsInvoked);
        Assert.True(param3.IsInvoked);
        Assert.True(param4.IsInvoked);
        Assert.True(param5.IsInvoked);
        Assert.True(param6.IsInvoked);
        Assert.True(param7.IsInvoked);
        Assert.True(param8.IsInvoked);
        Assert.True(param9.IsInvoked);
        Assert.True(param10.IsInvoked);
        Assert.True(param11.IsInvoked);
        Assert.True(param12.IsInvoked);
        Assert.True(param13.IsInvoked);
        Assert.True(param14.IsInvoked);
        Assert.True(param15.IsInvoked);

        static async ValueTask ActionMethodAsync(
            ActionParam1 param1,
            ActionParam2 param2,
            ActionParam3 param3,
            ActionParam4 param4,
            ActionParam5 param5,
            ActionParam6 param6,
            ActionParam7 param7,
            ActionParam8 param8,
            ActionParam9 param9,
            ActionParam10 param10,
            ActionParam11 param11,
            ActionParam12 param12,
            ActionParam13 param13,
            ActionParam14 param14,
            ActionParam15 param15)
        {
            param1.IsInvoked = true;
            param2.IsInvoked = true;
            param3.IsInvoked = true;
            param4.IsInvoked = true;
            param5.IsInvoked = true;
            param6.IsInvoked = true;
            param7.IsInvoked = true;
            param8.IsInvoked = true;
            param9.IsInvoked = true;
            param10.IsInvoked = true;
            param11.IsInvoked = true;
            param12.IsInvoked = true;
            param13.IsInvoked = true;
            param14.IsInvoked = true;
            param15.IsInvoked = true;
        }
    }

    [Fact]
    public static async Task AsFuncValueAsync16_ExpectInvoked()
    {
        var param1 = new ActionParam1();
        var param2 = new ActionParam2();
        var param3 = new ActionParam3();
        var param4 = new ActionParam4();
        var param5 = new ActionParam5();
        var param6 = new ActionParam6();
        var param7 = new ActionParam7();
        var param8 = new ActionParam8();
        var param9 = new ActionParam9();
        var param10 = new ActionParam10();
        var param11 = new ActionParam11();
        var param12 = new ActionParam12();
        var param13 = new ActionParam13();
        var param14 = new ActionParam14();
        var param15 = new ActionParam15();
        var param16 = new ActionParam16();

        var actionAsync = ActionMethodAsync;
        var unit = await actionAsync.AsFuncValueAsync().Invoke(
            param1,
            param2,
            param3,
            param4,
            param5,
            param6,
            param7,
            param8,
            param9,
            param10,
            param11,
            param12,
            param13,
            param14,
            param15,
            param16);

        AssertHelper.AssertDefault(in unit);
        Assert.True(param1.IsInvoked);
        Assert.True(param2.IsInvoked);
        Assert.True(param3.IsInvoked);
        Assert.True(param4.IsInvoked);
        Assert.True(param5.IsInvoked);
        Assert.True(param6.IsInvoked);
        Assert.True(param7.IsInvoked);
        Assert.True(param8.IsInvoked);
        Assert.True(param9.IsInvoked);
        Assert.True(param10.IsInvoked);
        Assert.True(param11.IsInvoked);
        Assert.True(param12.IsInvoked);
        Assert.True(param13.IsInvoked);
        Assert.True(param14.IsInvoked);
        Assert.True(param15.IsInvoked);
        Assert.True(param16.IsInvoked);

        static async ValueTask ActionMethodAsync(
            ActionParam1 param1,
            ActionParam2 param2,
            ActionParam3 param3,
            ActionParam4 param4,
            ActionParam5 param5,
            ActionParam6 param6,
            ActionParam7 param7,
            ActionParam8 param8,
            ActionParam9 param9,
            ActionParam10 param10,
            ActionParam11 param11,
            ActionParam12 param12,
            ActionParam13 param13,
            ActionParam14 param14,
            ActionParam15 param15,
            ActionParam16 param16)
        {
            param1.IsInvoked = true;
            param2.IsInvoked = true;
            param3.IsInvoked = true;
            param4.IsInvoked = true;
            param5.IsInvoked = true;
            param6.IsInvoked = true;
            param7.IsInvoked = true;
            param8.IsInvoked = true;
            param9.IsInvoked = true;
            param10.IsInvoked = true;
            param11.IsInvoked = true;
            param12.IsInvoked = true;
            param13.IsInvoked = true;
            param14.IsInvoked = true;
            param15.IsInvoked = true;
            param16.IsInvoked = true;
        }
    }
}

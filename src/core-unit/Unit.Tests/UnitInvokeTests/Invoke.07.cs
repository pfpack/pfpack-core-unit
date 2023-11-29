﻿using Moq;
using NUnit.Framework;
using PrimeFuncPack.UnitTest;
using System;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Core.Tests;

partial class UnitInvokeTests
{
    [Test]
    public void Invoke_07_ActionIsNull_ExpectArgumentNullException()
    {
        Action<StructType, RefType, string, int, object, DateTime, StructType?> action = null!;

        var arg1 = SomeTextStructType;
        var arg2 = PlusFifteenIdRefType;
        var arg3 = TabString;
        var arg4 = MinusFortyFive;
        var arg5 = new { Value = PlusTwoHundredPointFive };
        var arg6 = Year2015March11H01Min15;
        var arg7 = NullTextStructType;

        var ex = Assert.Throws<ArgumentNullException>(() => _ = Unit.Invoke(action, arg1, arg2, arg3, arg4, arg5, arg6, arg7));
        Assert.That(ex!.ParamName, Is.EqualTo("action"));
    }

    [Test]
    public void Invoke_07_ExpectCallActionOnce()
    {
        var mockAction = MockActionFactory.CreateMockAction<StructType, RefType?, string, int, object?, DateTime, StructType?>();

        var arg1 = SomeTextStructType;
        var arg2 = (RefType?)null;
        var arg3 = TabString;
        var arg4 = MinusFortyFive;
        var arg5 = new { Value = PlusTwoHundredPointFive };
        var arg6 = Year2015March11H01Min15;
        var arg7 = (StructType?)null;

        var actual = Unit.Invoke(mockAction.Object.Invoke, arg1, arg2, arg3, arg4, arg5, arg6, arg7);

        Assert.That(actual, Is.EqualTo(Unit.Value));
        mockAction.Verify(a => a.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7), Times.Once);
    }
}

#nullable enable

using System;
using System.Threading;
using System.Threading.Tasks;
using PrimeFuncPack.UnitTest;
using Xunit;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Core.Tests;

partial class AsyncValueFuncTest
{
    [Fact]
    public void From_13_SourceFuncIsNull_ExpectArgumentNullException()
    {
        var sourceFunc = (Func<long, RecordType, string?, object?, RecordType?, object?, RecordType, DateTimeOffset, object, DateTimeKind, string, int, RecordType?, CancellationToken, ValueTask<long>>)null!;
        var ex = Assert.Throws<ArgumentNullException>(() => _ = AsyncValueFunc.From(sourceFunc));
        Assert.Equal("funcAsync", ex.ParamName);
    }

    [Theory]
    [MemberData(nameof(TestEntitySource.RefTypes), MemberType = typeof(TestEntitySource))]
    public async ValueTask From_13_ThenInvokeAsync_ExpectResultOfSourceFunc(
        RefType sourceFuncResult)
    {
        var actual = AsyncValueFunc.From<decimal, StructType, RefType?, RecordType?, long, int, RefType, DateTimeKind, RefType, object?, string, RecordType, string?, RefType>(
            (_, _, _, _, _, _, _, _, _, _, _, _, _, _) => ValueTask.FromResult(sourceFuncResult));

        var cancellationToken = new CancellationToken(canceled: false);

        var actualResult = await actual.InvokeAsync(
            decimal.One, SomeTextStructType, PlusFifteenIdRefType, ZeroIdNullNameRecord, default, default, MinusFifteenIdRefType, DateTimeKind.Unspecified, null!, new(), ThreeWhiteSpacesString, MinusFifteenIdNullNameRecord, EmptyString, cancellationToken);

        Assert.Equal(sourceFuncResult, actualResult);
    }
}

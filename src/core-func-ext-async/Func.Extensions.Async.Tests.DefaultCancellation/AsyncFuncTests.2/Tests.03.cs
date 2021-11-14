using PrimeFuncPack.UnitTest;
using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using static PrimeFuncPack.UnitTest.TestData;

namespace PrimeFuncPack.Core.Tests;

partial class AsyncFuncTests2
{
    [Fact]
    public void From_03_SourceFuncIsNull_ExpectArgumentNullException()
    {
        var sourceFunc = (Func<RecordType?, StructType, string, Task<RefType?>>)null!;
        var ex = Assert.Throws<ArgumentNullException>(() => _ = AsyncFunc.From(sourceFunc));
        Assert.Equal("funcAsync", ex.ParamName);
    }

    [Theory]
    [MemberData(nameof(AsyncTestCaseSources.StructType), MemberType = typeof(AsyncTestCaseSources))]
    public async Task From_03_ThenInvokeAsync_ExpectResultOfSourceFunc(
        StructType sourceFuncResult)
    {
        var actual = AsyncFunc.From<string?, RefType, RecordType?, StructType>(
            (_, _, _) => Task.FromResult(sourceFuncResult));

        var actualResult = await actual.InvokeAsync(
            LowerSomeString, ZeroIdRefType, PlusFifteenIdLowerSomeStringNameRecord);

        Assert.Equal(sourceFuncResult, actualResult);
    }
}

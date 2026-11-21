using Xunit;

namespace PrimeFuncPack.Core.Tests;

partial class AssertHelper
{
    internal static void DefaultStruct<T>(scoped ref readonly T value)
        where T : struct
    {
        T defaultValue = default;
        var expected = InnerToBytes(in defaultValue);

        var actual = InnerToBytes(in value);

        Assert.Equal(expected, actual);
    }
}

using Xunit;

namespace PrimeFuncPack.Core.Tests;

partial class AssertHelper
{
    internal static void AssertDefault<T>(scoped ref readonly T value)
        where T : struct
    {
        T defaultValue = default;
        var expected = StructConverter.ToBytes(in defaultValue);

        var actual = StructConverter.ToBytes(in value);

        Assert.Equal(expected, actual);
    }
}

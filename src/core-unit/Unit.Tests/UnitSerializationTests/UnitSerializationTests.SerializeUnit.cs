using System;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace PrimeFuncPack.Core.Tests;

partial class UnitSerializationTests
{
    [Theory]
    [MemberData(nameof(JsonSerializerOptionsCases))]
    public static void SerializeUnitToString_ExpectEmptyJsonObject(JsonSerializerOptions? options)
    {
        var actual = JsonSerializer.Serialize(default(Unit), options);
        var expected = JsonSerializer.Serialize(new JsonObject()); // default options expected
        Assert.Equal(expected, actual);
    }

    [Theory]
    [MemberData(nameof(JsonSerializerOptionsCases))]
    public static void SerializeUnitToNode_ExpectEmptyJsonObject(JsonSerializerOptions? options)
    {
        var actual = JsonSerializer.SerializeToNode(default(Unit), options);
        var expected = new JsonObject();
        Assert.Equal(expected, actual);
    }
}

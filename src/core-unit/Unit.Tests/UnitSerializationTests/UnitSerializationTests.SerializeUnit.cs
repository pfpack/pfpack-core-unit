using System;
using System.Text.Json;
using System.Text.Json.Nodes;
using Xunit;

namespace PrimeFuncPack.Core.Tests;

partial class UnitSerializationTests
{
    [Theory]
    [MemberData(nameof(JsonSerializerOptionsCases))]
    public static void SerializeUnitToString_ExpectEmptyJsonObject(JsonSerializerOptions? options)
    {
        var expected = JsonSerializer.Serialize(new JsonObject());
        var actual = JsonSerializer.Serialize(default(Unit), options);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [MemberData(nameof(JsonSerializerOptionsCases))]
    public static void SerializeUnitToNode_ExpectEmptyJsonObject(JsonSerializerOptions? options)
    {
        var expected = new JsonObject();
        var actual = JsonSerializer.SerializeToNode(default(Unit), options);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [MemberData(nameof(JsonSerializerOptionsCases))]
    public static void SerializeDtoWithUnitToString_ExpectEmptyJsonObject(JsonSerializerOptions? options)
    {
        var expected = JsonSerializer.Serialize(BuildDtoWithUnitValueNode());
        var actual = JsonSerializer.Serialize(new DtoWithUnit(), options);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [MemberData(nameof(JsonSerializerOptionsCases))]
    public static void SerializeDtoWithUnitToNode_ExpectEmptyJsonObject(JsonSerializerOptions? options)
    {
        var expected = BuildDtoWithUnitValueNode();
        var actual = JsonSerializer.SerializeToNode(new DtoWithUnit(), options);
        Assert.Equal(expected, actual);
    }
}

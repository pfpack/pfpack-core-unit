using System;
using System.Text.Json;
using System.Text.Json.Nodes;
using Xunit;

namespace PrimeFuncPack.Core.Tests;

partial class UnitSerializationTests
{
    [Theory]
    [MemberData(nameof(JsonSerializerOptionsCases))]
    public static void DeserializeUnitFromString_ExpectNoException(JsonSerializerOptions? options)
    {
        var source = JsonSerializer.Serialize(new JsonObject());
        _ = JsonSerializer.Deserialize<Unit>(source, options);
    }

    [Theory]
    [MemberData(nameof(JsonSerializerOptionsCases))]
    public static void DeserializeUnitFromNode_ExpectNoException(JsonSerializerOptions? options)
    {
        var source = new JsonObject();
        _ = JsonSerializer.Deserialize<Unit>(source, options);
    }

    [Theory]
    [MemberData(nameof(JsonSerializerOptionsCases))]
    public static void DeserializeDtoWithUnitFromString_ExpectNoException(JsonSerializerOptions? options)
    {
        var source = JsonSerializer.Serialize(BuildDtoWithUnitValueNode());
        _ = JsonSerializer.Deserialize<DtoWithUnit>(source, options);
    }

    [Theory]
    [MemberData(nameof(JsonSerializerOptionsCases))]
    public static void DeserializeDtoWithUnitFromNode_ExpectNoException(JsonSerializerOptions? options)
    {
        var source = BuildDtoWithUnitValueNode();
        _ = JsonSerializer.Deserialize<DtoWithUnit>(source, options);
    }
}

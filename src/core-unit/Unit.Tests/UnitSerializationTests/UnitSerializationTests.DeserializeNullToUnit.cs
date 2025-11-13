using System;
using System.Text.Json;
using System.Text.Json.Nodes;
using Xunit;

namespace PrimeFuncPack.Core.Tests;

partial class UnitSerializationTests
{
    [Theory]
    [MemberData(nameof(JsonSerializerOptionsCases))]
    public static void DeserializeNullToUnitFromString_ExpectNoException(JsonSerializerOptions? options)
    {
        var sourceString = JsonSerializer.Serialize<JsonNode?>(null);
        _ = JsonSerializer.Deserialize<Unit>(sourceString, options);
    }

    [Theory]
    [MemberData(nameof(JsonSerializerOptionsCases))]
    public static void DeserializeNullToUnitFromNode_ExpectNoException(JsonSerializerOptions? options)
    {
        _ = JsonSerializer.Deserialize<Unit>((JsonNode?)null, options);
    }

    [Theory]
    [MemberData(nameof(JsonSerializerOptionsCases))]
    public static void DeserializeDtoWithNullToDtoWithUnitFromString_ExpectNoException(JsonSerializerOptions? options)
    {
        var sourceString = JsonSerializer.Serialize<JsonNode?>(BuildDtoWithNullValueNode());
        _ = JsonSerializer.Deserialize<DtoWithUnit>(sourceString, options);
    }

    [Theory]
    [MemberData(nameof(JsonSerializerOptionsCases))]
    public static void DeserializeDtoWithNullToDtoWithUnitFromNode_ExpectNoException(JsonSerializerOptions? options)
    {
        _ = JsonSerializer.Deserialize<DtoWithUnit>(BuildDtoWithNullValueNode(), options);
    }
}

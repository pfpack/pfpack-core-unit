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
        var unit = JsonSerializer.Deserialize<Unit>(sourceString, options);
        AssertHelper.AssertDefault(in unit);
    }

    [Theory]
    [MemberData(nameof(JsonSerializerOptionsCases))]
    public static void DeserializeNullToUnitFromNode_ExpectNoException(JsonSerializerOptions? options)
    {
        var unit = JsonSerializer.Deserialize<Unit>((JsonNode?)null, options);
        AssertHelper.AssertDefault(in unit);
    }

    [Theory]
    [MemberData(nameof(JsonSerializerOptionsCases))]
    public static void DeserializeDtoWithNullToDtoWithUnitFromString_ExpectNoException(JsonSerializerOptions? options)
    {
        var sourceString = JsonSerializer.Serialize<JsonNode?>(BuildDtoWithNullValueNode());
        var result = JsonSerializer.Deserialize<DtoWithUnit>(sourceString, options);
        var unit = result!.Value;
        AssertHelper.AssertDefault(in unit);
    }

    [Theory]
    [MemberData(nameof(JsonSerializerOptionsCases))]
    public static void DeserializeDtoWithNullToDtoWithUnitFromNode_ExpectNoException(JsonSerializerOptions? options)
    {
        var result = JsonSerializer.Deserialize<DtoWithUnit>(BuildDtoWithNullValueNode(), options);
        var unit = result!.Value;
        AssertHelper.AssertDefault(in unit);
    }
}

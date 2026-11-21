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
        var unit = JsonSerializer.Deserialize<Unit>(source, options);
        AssertHelper.DefaultStruct(in unit);
    }

    [Theory]
    [MemberData(nameof(JsonSerializerOptionsCases))]
    public static void DeserializeUnitFromNode_ExpectNoException(JsonSerializerOptions? options)
    {
        var source = new JsonObject();
        var unit = JsonSerializer.Deserialize<Unit>(source, options);
        AssertHelper.DefaultStruct(in unit);
    }

    [Theory]
    [MemberData(nameof(JsonSerializerOptionsCases))]
    public static void DeserializeDtoWithUnitFromString_ExpectNoException(JsonSerializerOptions? options)
    {
        var source = JsonSerializer.Serialize(BuildDtoWithUnitValueNode());
        var result = JsonSerializer.Deserialize<DtoWithUnit>(source, options);
        var unit = result!.Value;
        AssertHelper.DefaultStruct(in unit);
    }

    [Theory]
    [MemberData(nameof(JsonSerializerOptionsCases))]
    public static void DeserializeDtoWithUnitFromNode_ExpectNoException(JsonSerializerOptions? options)
    {
        var source = BuildDtoWithUnitValueNode();
        var result = JsonSerializer.Deserialize<DtoWithUnit>(source, options);
        var unit = result!.Value;
        AssertHelper.DefaultStruct(in unit);
    }
}

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using Xunit;

namespace PrimeFuncPack.Core.Tests;

partial class UnitSerializationTests
{
    [Theory]
    [MemberData(nameof(DeserializeArrayToUnit_ExpectNoException_Cases))]
    public static void DeserializeArrayToUnitFromString_ExpectNoException(
        JsonArray source,
        JsonSerializerOptions? options)
    {
        var sourceString = JsonSerializer.Serialize(source);
        _ = JsonSerializer.Deserialize<Unit>(sourceString, options);
    }

    [Theory]
    [MemberData(nameof(DeserializeArrayToUnit_ExpectNoException_Cases))]
    public static void DeserializeArrayToUnitFromObject_ExpectNoException(
        JsonArray source,
        JsonSerializerOptions? options)
    {
        _ = JsonSerializer.Deserialize<Unit>(source, options);
    }

    [Theory]
    [MemberData(nameof(DeserializeArrayToUnit_ExpectNoException_Cases))]
    public static void DeserializeDtoWithArrayToDtoWithUnitFromString_ExpectNoException(
        JsonArray source,
        JsonSerializerOptions? options)
    {
        var sourceString = JsonSerializer.Serialize(BuildDtoWithValueNode(source));
        _ = JsonSerializer.Deserialize<DtoWithUnit>(sourceString, options);
    }

    [Theory]
    [MemberData(nameof(DeserializeArrayToUnit_ExpectNoException_Cases))]
    public static void DeserializeDtoWithArrayToDtoWithUnitFromObject_ExpectNoException(
        JsonArray source,
        JsonSerializerOptions? options)
    {
        _ = JsonSerializer.Deserialize<DtoWithUnit>(BuildDtoWithValueNode(source), options);
    }

    public static IEnumerable<TheoryDataRow<JsonArray, JsonSerializerOptions?>> DeserializeArrayToUnit_ExpectNoException_Cases
    {
        get
        {
            var arrays = new JsonArray[]
            {
                [],
                new(new JsonArray(null, true, false, -1, 0, 1.1m, 1.2, "2"))
            };

            foreach (var array in arrays)
            {
                foreach (var options in EnumerateJsonSerializerOptionsCases())
                {
                    yield return (array, options);
                }
            }
        }
    }
}

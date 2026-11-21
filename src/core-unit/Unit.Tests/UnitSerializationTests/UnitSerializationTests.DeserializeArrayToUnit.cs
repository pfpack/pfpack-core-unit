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
        var unit = JsonSerializer.Deserialize<Unit>(sourceString, options);
        AssertHelper.DefaultStruct(in unit);
    }

    [Theory]
    [MemberData(nameof(DeserializeArrayToUnit_ExpectNoException_Cases))]
    public static void DeserializeArrayToUnitFromObject_ExpectNoException(
        JsonArray source,
        JsonSerializerOptions? options)
    {
        var unit = JsonSerializer.Deserialize<Unit>(source, options);
        AssertHelper.DefaultStruct(in unit);
    }

    [Theory]
    [MemberData(nameof(DeserializeArrayToUnit_ExpectNoException_Cases))]
    public static void DeserializeDtoWithArrayToDtoWithUnitFromString_ExpectNoException(
        JsonArray source,
        JsonSerializerOptions? options)
    {
        var sourceString = JsonSerializer.Serialize(BuildDtoWithValueNode(source));
        var result = JsonSerializer.Deserialize<DtoWithUnit>(sourceString, options);
        var unit = result!.Value;
        AssertHelper.DefaultStruct(in unit);
    }

    [Theory]
    [MemberData(nameof(DeserializeArrayToUnit_ExpectNoException_Cases))]
    public static void DeserializeDtoWithArrayToDtoWithUnitFromObject_ExpectNoException(
        JsonArray source,
        JsonSerializerOptions? options)
    {
        var result = JsonSerializer.Deserialize<DtoWithUnit>(BuildDtoWithValueNode(source), options);
        var unit = result!.Value;
        AssertHelper.DefaultStruct(in unit);
    }

    public static IEnumerable<TheoryDataRow<JsonArray, JsonSerializerOptions?>> DeserializeArrayToUnit_ExpectNoException_Cases
    {
        get
        {
            IEnumerable<JsonArray> arrays =
            [
                [],
                [
                    null, true, false, -1, 0, 1.1m, 1.2, "2",
                    (JsonArray)[],
                    (JsonArray)([true, false, null, -2, 0, 2.1m, 2.2, "3"]),
                ],
            ];

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

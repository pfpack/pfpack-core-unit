using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using Xunit;

namespace PrimeFuncPack.Core.Tests;

partial class UnitSerializationTests
{
    [Theory]
    [MemberData(nameof(DeserializeNonEmptyObjectToUnit_ExpectNoException_Cases))]
    public static void DeserializeNonEmptyObjectToUnitFromString_ExpectNoException(
        JsonObject source,
        JsonSerializerOptions? options)
    {
        var sourceString = JsonSerializer.Serialize(source);
        var unit = JsonSerializer.Deserialize<Unit>(sourceString, options);
        AssertHelper.AssertDefault(in unit);
    }

    [Theory]
    [MemberData(nameof(DeserializeNonEmptyObjectToUnit_ExpectNoException_Cases))]
    public static void DeserializeNonEmptyObjectToUnitFromObject_ExpectNoException(
        JsonObject source,
        JsonSerializerOptions? options)
    {
        var unit = JsonSerializer.Deserialize<Unit>(source, options);
        AssertHelper.AssertDefault(in unit);
    }

    [Theory]
    [MemberData(nameof(DeserializeNonEmptyObjectToUnit_ExpectNoException_Cases))]
    public static void DeserializeDtoWithNonEmptyObjectToDtoWithUnitFromString_ExpectNoException(
        JsonObject source,
        JsonSerializerOptions? options)
    {
        var sourceString = JsonSerializer.Serialize(BuildDtoWithValueNode(source));
        var result = JsonSerializer.Deserialize<DtoWithUnit>(sourceString, options);
        var unit = result!.Value;
        AssertHelper.AssertDefault(in unit);
    }

    [Theory]
    [MemberData(nameof(DeserializeNonEmptyObjectToUnit_ExpectNoException_Cases))]
    public static void DeserializeDtoWithNonEmptyObjectToDtoWithUnitFromObject_ExpectNoException(
        JsonObject source,
        JsonSerializerOptions? options)
    {
        var result = JsonSerializer.Deserialize<DtoWithUnit>(BuildDtoWithValueNode(source), options);
        var unit = result!.Value;
        AssertHelper.AssertDefault(in unit);
    }

    public static IEnumerable<TheoryDataRow<JsonObject, JsonSerializerOptions?>> DeserializeNonEmptyObjectToUnit_ExpectNoException_Cases
    {
        get
        {
            var objects = new JsonObject[]
            {
                new()
                {
                    ["id"] = "0AFB2897-BA58-4E10-A083-4C33341B6238"
                },
                new()
                {
                    ["id"] = "0AFB2897-BA58-4E10-A083-4C33341B6238",
                    ["body"] = new JsonObject
                    {
                        ["foo"] = 1,
                        ["bar"] = "2",
                        ["baz"] = new JsonArray(null, true, 1, "2"),
                    },
                    ["qux"] = new JsonArray(false, -1, 0, 1.1m, 1.2, "3"),
                    ["quux"] = new JsonArray(),
                    ["corge"] = -1.1m,
                    ["grault"] = -1.2,
                    ["garply"] = true,
                    ["waldo"] = false,
                    ["fred"] = null,
                }
            };

            foreach (var obj in objects)
            {
                foreach (var options in EnumerateJsonSerializerOptionsCases())
                {
                    yield return (obj, options);
                }
            }
        }
    }
}

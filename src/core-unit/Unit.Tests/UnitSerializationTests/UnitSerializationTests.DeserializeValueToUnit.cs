using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using Xunit;

namespace PrimeFuncPack.Core.Tests;

partial class UnitSerializationTests
{
    [Theory]
    [MemberData(nameof(DeserializeValueToUnit_ExpectNoException_Cases))]
    public static void DeserializeValueToUnitFromString_ExpectNoException(
        JsonValue source,
        JsonSerializerOptions? options)
    {
        var sourceString = JsonSerializer.Serialize(source);
        _ = JsonSerializer.Deserialize<Unit>(sourceString, options);
    }

    [Theory]
    [MemberData(nameof(DeserializeValueToUnit_ExpectNoException_Cases))]
    public static void DeserializeValueToUnitFromObject_ExpectNoException(
        JsonValue source,
        JsonSerializerOptions? options)
    {
        _ = JsonSerializer.Deserialize<Unit>(source, options);
    }

    [Theory]
    [MemberData(nameof(DeserializeValueToUnit_ExpectNoException_Cases))]
    public static void DeserializeDtoWithValueToDtoWithUnitFromString_ExpectNoException(
        JsonValue source,
        JsonSerializerOptions? options)
    {
        var sourceString = JsonSerializer.Serialize(BuildDtoWithValueNode(source));
        _ = JsonSerializer.Deserialize<DtoWithUnit>(sourceString, options);
    }

    [Theory]
    [MemberData(nameof(DeserializeValueToUnit_ExpectNoException_Cases))]
    public static void DeserializeDtoWithValueToDtoWithUnitFromObject_ExpectNoException(
        JsonValue source,
        JsonSerializerOptions? options)
    {
        _ = JsonSerializer.Deserialize<DtoWithUnit>(BuildDtoWithValueNode(source), options);
    }

    public static IEnumerable<TheoryDataRow<JsonValue, JsonSerializerOptions?>> DeserializeValueToUnit_ExpectNoException_Cases
    {
        get
        {
            var result = new List<TheoryDataRow<JsonValue, JsonSerializerOptions?>>();

            foreach (var value in EnumerateValues())
            {
                foreach (var options in EnumerateJsonSerializerOptionsCases())
                {
                    result.Add((value, options));
                }
            }

            return result;

            static IEnumerable<JsonValue> EnumerateValues()
                =>
                [
                     JsonValue.Create(true),
                     JsonValue.Create(false),

                     JsonValue.Create(int.MinValue),
                     JsonValue.Create(-1),
                     JsonValue.Create(0),
                     JsonValue.Create(1.1m),
                     JsonValue.Create(1.2),
                     JsonValue.Create(int.MaxValue),

                     JsonValue.Create(double.MinValue),
                     JsonValue.Create(double.MaxValue),

                     JsonValue.Create(""),
                     JsonValue.Create("1"),
                     JsonValue.Create("0AFB2897-BA58-4E10-A083-4C33341B6238"),
                ];
        }
    }
}

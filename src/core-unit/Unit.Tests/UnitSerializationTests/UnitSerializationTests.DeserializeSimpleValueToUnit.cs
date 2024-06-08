using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace PrimeFuncPack.Core.Tests;

partial class UnitSerializationTests
{
    [Theory]
    [MemberData(nameof(DeserializeSimpleValueToUnit_ExpectNoException_Cases))]
    public static void DeserializeSimpleValueToUnitFromString_ExpectNoException(
        JsonValue source,
        JsonSerializerOptions? options)
    {
        var sourceString = JsonSerializer.Serialize(source);
        _ = JsonSerializer.Deserialize<Unit>(sourceString, options);
    }

    [Theory]
    [MemberData(nameof(DeserializeSimpleValueToUnit_ExpectNoException_Cases))]
    public static void DeserializeSimpleValueToUnitFromObject_ExpectNoException(
        JsonValue source,
        JsonSerializerOptions? options)
    {
        _ = JsonSerializer.Deserialize<Unit>(source, options);
    }

    [Theory]
    [MemberData(nameof(DeserializeSimpleValueToUnit_ExpectNoException_Cases))]
    public static void DeserializeDtoWithSimpleValueToDtoWithUnitFromString_ExpectNoException(
        JsonValue source,
        JsonSerializerOptions? options)
    {
        var sourceString = JsonSerializer.Serialize(BuildDtoWithValueNode(source));
        _ = JsonSerializer.Deserialize<DtoWithUnit>(sourceString, options);
    }

    [Theory]
    [MemberData(nameof(DeserializeSimpleValueToUnit_ExpectNoException_Cases))]
    public static void DeserializeDtoWithSimpleValueToDtoWithUnitFromObject_ExpectNoException(
        JsonValue source,
        JsonSerializerOptions? options)
    {
        _ = JsonSerializer.Deserialize<DtoWithUnit>(BuildDtoWithValueNode(source), options);
    }

    public static TheoryData<JsonValue, JsonSerializerOptions?> DeserializeSimpleValueToUnit_ExpectNoException_Cases
    {
        get
        {
            IEnumerable<JsonValue> values =
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
                JsonValue.Create("0AFB2897-BA58-4E10-A083-4C33341B6238")
            ];

            var result = new TheoryData<JsonValue, JsonSerializerOptions?>();

            foreach (var value in values)
            {
                foreach (var options in BuildJsonSerializerOptionsCollection())
                {
                    result.Add(value, options);
                }
            }

            return result;
        }
    }
}

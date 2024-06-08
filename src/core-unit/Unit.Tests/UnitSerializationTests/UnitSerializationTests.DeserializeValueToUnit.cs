using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;

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

    public static TheoryData<JsonValue, JsonSerializerOptions?> DeserializeValueToUnit_ExpectNoException_Cases
    {
        get
        {
            var result = new TheoryData<JsonValue, JsonSerializerOptions?>();

            foreach (var value in EnumerateValues())
            {
                foreach (var options in EnumerateJsonSerializerOptionsCases())
                {
                    result.Add(value, options);
                }
            }

            return result;

            static IEnumerable<JsonValue> EnumerateValues()
            {
                yield return JsonValue.Create(true);
                yield return JsonValue.Create(false);

                yield return JsonValue.Create(int.MinValue);
                yield return JsonValue.Create(-1);
                yield return JsonValue.Create(0);
                yield return JsonValue.Create(1.1m);
                yield return JsonValue.Create(1.2);
                yield return JsonValue.Create(int.MaxValue);

                yield return JsonValue.Create(double.MinValue);
                yield return JsonValue.Create(double.MaxValue);

                yield return JsonValue.Create("");
                yield return JsonValue.Create("1");
                yield return JsonValue.Create("0AFB2897-BA58-4E10-A083-4C33341B6238");
            }
        }
    }
}

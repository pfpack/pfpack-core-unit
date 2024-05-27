using System;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace PrimeFuncPack.Core.Tests;

partial class UnitSerializationTests
{
    [Theory]
    [MemberData(nameof(DeserializeSimpleValueToUnit_ExpectNoException_Cases))]
    public static void DeserializeSimpleValueToUnitFromString_ExpectNoException(
        JsonNode source,
        JsonSerializerOptions? options)
    {
        var sourceString = JsonSerializer.Serialize(source);
        _ = JsonSerializer.Deserialize<Unit>(sourceString, options);
    }

    [Theory]
    [MemberData(nameof(DeserializeSimpleValueToUnit_ExpectNoException_Cases))]
    public static void DeserializeSimpleValueToUnitFromObject_ExpectNoException(
        JsonNode source,
        JsonSerializerOptions? options)
    {
        _ = JsonSerializer.Deserialize<Unit>(source, options);
    }

    public static TheoryData<JsonNode, JsonSerializerOptions?> DeserializeSimpleValueToUnit_ExpectNoException_Cases
    {
        get
        {
            var values = new JsonNode[]
            {
                true,
                false,

                int.MinValue,
                -1,
                0,
                1.1m,
                1.2,
                int.MaxValue,

                double.MinValue,
                double.MaxValue,

                "",
                "1",
                "0AFB2897-BA58-4E10-A083-4C33341B6238"
            };

            var result = new TheoryData<JsonNode, JsonSerializerOptions?>();

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

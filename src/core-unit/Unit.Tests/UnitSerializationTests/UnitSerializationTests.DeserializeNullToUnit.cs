using System;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace PrimeFuncPack.Core.Tests;

partial class UnitSerializationTests
{
    [Theory]
    [MemberData(nameof(JsonSerializerOptionsCases))]
    public static void DeserializeNullToUnitFromString_ExpectNoException(JsonSerializerOptions? options)
    {
        var source = JsonSerializer.Serialize<JsonNode?>(null);
        _ = JsonSerializer.Deserialize<Unit>(source, options);
    }

    [Theory]
    [MemberData(nameof(JsonSerializerOptionsCases))]
    public static void DeserializeNullToUnitFromNode_ExpectNoException(JsonSerializerOptions? options)
    {
        JsonNode? source = null;
        _ = JsonSerializer.Deserialize<Unit>(source, options);
    }
}

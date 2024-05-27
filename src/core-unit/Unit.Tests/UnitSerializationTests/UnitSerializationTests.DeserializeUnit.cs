using System;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace PrimeFuncPack.Core.Tests;

partial class UnitSerializationTests
{
    [Theory]
    [MemberData(nameof(JsonSerializerOptionsCases))]
    public static void DeserializeUnitFromString_ExpectNoException(JsonSerializerOptions? options)
    {
        var source = JsonSerializer.Serialize(new JsonObject()); // default options expected
        _ = JsonSerializer.Deserialize<Unit>(source, options);
    }

    [Theory]
    [MemberData(nameof(JsonSerializerOptionsCases))]
    public static void DeserializeUnitFromNode_ExpectNoException(JsonSerializerOptions? options)
    {
        var source = new JsonObject();
        _ = JsonSerializer.Deserialize<Unit>(source, options);
    }
}

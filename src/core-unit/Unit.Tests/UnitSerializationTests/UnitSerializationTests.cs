using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace PrimeFuncPack.Core.Tests;

public static partial class UnitSerializationTests
{
    private const string ValueName = "value";

    public static TheoryData<JsonSerializerOptions?> JsonSerializerOptionsCases
        =>
        new(BuildJsonSerializerOptionsCollection().ToArray());

    private static IEnumerable<JsonSerializerOptions?> BuildJsonSerializerOptionsCollection()
    {
        yield return null;
        yield return JsonSerializerOptions.Default;
        yield return new(JsonSerializerDefaults.General);
        yield return new(JsonSerializerDefaults.Web);
    }

    private static JsonObject BuildDtoWithUnitValueNode()
        =>
        new() { [ValueName] = new JsonObject() };

    private static JsonObject BuildDtoWithNullValueNode()
        =>
        new() { [ValueName] = null };

    private static JsonObject BuildDtoWithArbitraryValueNode(JsonNode value)
        =>
        new() { [ValueName] = value.DeepClone() };

    private sealed record DtoWithUnit
    {
        [JsonPropertyName(ValueName)]
        public Unit Value { get; init; }
    }
}

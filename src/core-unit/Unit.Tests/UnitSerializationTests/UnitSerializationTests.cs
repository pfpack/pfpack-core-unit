using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace PrimeFuncPack.Core.Tests;

public static partial class UnitSerializationTests
{
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
}

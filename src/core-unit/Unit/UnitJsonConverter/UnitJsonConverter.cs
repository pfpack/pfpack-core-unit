using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace System;

internal sealed class UnitJsonConverter : JsonConverter<Unit>
{
    public override Unit Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        =>
        default;

    public override void Write(Utf8JsonWriter writer, Unit value, JsonSerializerOptions options)
    {
        Debug.Assert(writer is not null);

        writer.WriteStartObject();
        writer.WriteEndObject();
    }
}

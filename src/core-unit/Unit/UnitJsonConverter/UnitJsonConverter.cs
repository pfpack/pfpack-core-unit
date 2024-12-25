using System.Text.Json;
using System.Text.Json.Serialization;

namespace System;

internal sealed class UnitJsonConverter : JsonConverter<Unit>
{
    public override Unit Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        switch (reader.TokenType)
        {
            case JsonTokenType.StartObject:
            case JsonTokenType.StartArray:
                reader.Skip();
                return default;

            case JsonTokenType.String:
            case JsonTokenType.Number:
            case JsonTokenType.True:
            case JsonTokenType.False:
            case JsonTokenType.Null:
                return default;

            case var unexpected:
                throw new JsonException($"An unexpected JSON token type ({unexpected}).");
        };
    }

    public override void Write(Utf8JsonWriter writer, Unit value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        writer.WriteEndObject();
    }
}

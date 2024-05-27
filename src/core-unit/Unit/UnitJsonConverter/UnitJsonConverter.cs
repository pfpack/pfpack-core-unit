using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace System;

internal sealed class UnitJsonConverter : JsonConverter<Unit>
{
    public override Unit Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var tokenType = reader.TokenType;
        Debug.Assert(tokenType is not JsonTokenType.None);

        switch (tokenType)
        {
            case JsonTokenType.StartObject:
            case JsonTokenType.StartArray:
                reader.Skip();
                Debug.Assert(
                    tokenType is JsonTokenType.StartObject && reader.TokenType is JsonTokenType.EndObject ||
                    tokenType is JsonTokenType.StartArray && reader.TokenType is JsonTokenType.EndArray);
                return default;

            case JsonTokenType.String:
            case JsonTokenType.Number:
            case JsonTokenType.True:
            case JsonTokenType.False:
            case JsonTokenType.Null:
                return default;

            default:
                throw new JsonException($"An unexpected JSON token type ({tokenType}).");
        };
    }

    public override void Write(Utf8JsonWriter writer, Unit value, JsonSerializerOptions options)
    {
        Debug.Assert(writer is not null);

        writer.WriteStartObject();
        writer.WriteEndObject();
    }
}

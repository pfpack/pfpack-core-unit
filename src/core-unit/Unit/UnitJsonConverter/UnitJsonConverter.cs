using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace System;

internal sealed class UnitJsonConverter : JsonConverter<Unit>
{
    // We maintain that Unit can be derived from any input value
    // represented in any applicable JSON token.

    public override Unit Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        =>
        reader.TokenType switch
        {
            JsonTokenType.StartObject or
            JsonTokenType.StartArray
            =>
            ReadObjectOrArray(ref reader),

            JsonTokenType.String or
            JsonTokenType.Number or
            JsonTokenType.True or
            JsonTokenType.False or
            JsonTokenType.Null
            =>
            default,

            var unexpected
            =>
            throw new JsonException($"An unexpected JSON token type ({unexpected}).")
        };

    // We serialize Unit into an empty JSON object.

    public override void Write(Utf8JsonWriter writer, Unit value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        writer.WriteEndObject();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static Unit ReadObjectOrArray(ref Utf8JsonReader reader)
    {
        reader.Skip();
        return default;
    }
}

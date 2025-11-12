namespace System;

partial struct Unit
{
    // We maintain that Unit can be derived from any input value.

    // For the string versions we follow the contract which defines fail on null input,
    // to keep consistency between Parse and TryParse methods, taking into account that
    // TryParse has [NotNullWhen(true)] attribute on the input parameter.

    static Unit IParsable<Unit>.Parse(string s, IFormatProvider? provider)
    {
        _ = s ?? throw new ArgumentNullException(nameof(s));
        return default;
    }

    static bool IParsable<Unit>.TryParse(string? s, IFormatProvider? provider, out Unit result)
    {
        result = default;
        return s is not null;
    }

    static Unit ISpanParsable<Unit>.Parse(ReadOnlySpan<char> s, IFormatProvider? provider)
        =>
        default;

    static bool ISpanParsable<Unit>.TryParse(ReadOnlySpan<char> s, IFormatProvider? provider, out Unit result)
    {
        result = default;
        return true;
    }

    static Unit IUtf8SpanParsable<Unit>.Parse(ReadOnlySpan<byte> utf8Text, IFormatProvider? provider)
        =>
        default;

    static bool IUtf8SpanParsable<Unit>.TryParse(ReadOnlySpan<byte> utf8Text, IFormatProvider? provider, out Unit result)
    {
        result = default;
        return true;
    }
}

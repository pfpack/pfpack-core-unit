namespace System;

partial struct Unit
{
    string IFormattable.ToString(string? format, IFormatProvider? formatProvider)
        =>
        Format(format);

    bool ISpanFormattable.TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
        =>
        TryFormat(destination, out charsWritten, format);

    bool IUtf8SpanFormattable.TryFormat(Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
        =>
        TryFormat(utf8Destination, out bytesWritten, format);
}

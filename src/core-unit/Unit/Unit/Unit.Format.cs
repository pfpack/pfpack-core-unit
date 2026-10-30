#pragma warning disable CA1822 // Mark members as static

namespace System;

partial struct Unit
{
    public string Format(params ReadOnlySpan<char> format)
        =>
        UnitFormatter.Format(format);

    public byte[] FormatToUtf8(params ReadOnlySpan<char> format)
        =>
        UnitFormatter.FormatToUtf8(format).ToArray();

    public bool TryFormat(Span<char> destination, out int charsWritten, params ReadOnlySpan<char> format)
    {
        var formatted = UnitFormatter.Format(format);

        if (formatted.TryCopyTo(destination))
        {
            charsWritten = formatted.Length;
            return true;
        }

        charsWritten = default;
        return false;
    }

    public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, params ReadOnlySpan<char> format)
    {
        var utf8Formatted = UnitFormatter.FormatToUtf8(format);

        if (utf8Formatted.TryCopyTo(utf8Destination))
        {
            bytesWritten = utf8Formatted.Length;
            return true;
        }

        bytesWritten = default;
        return false;
    }
}

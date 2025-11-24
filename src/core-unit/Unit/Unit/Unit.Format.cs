#pragma warning disable CA1822 // Mark members as static

namespace System;

partial struct Unit
{
    public string Format(ReadOnlySpan<char> format)
        =>
        UnitFormatter.Format(format);

    // We use a design with byte array result and copying the result bytes for following:
    // - to provide to the user a possibility to work with both bytes and a span over them;
    // - not to expose the inner cache state despite it's protected by ReadOnlySpan.
    public byte[] FormatToUtf8(ReadOnlySpan<char> format)
        =>
        UnitFormatter.FormatToUtf8(format).ToArray();

    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format)
    {
        var formatted = UnitFormatter.Format(format);

        // Call TryCopyTo instead of CopyTo not to duplicate the length check here
        var result = formatted.TryCopyTo(destination);
        charsWritten = result ? formatted.Length : default;
        return result;
    }

    public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format)
    {
        var utf8Formatted = UnitFormatter.FormatToUtf8(format);

        // Call TryCopyTo instead of CopyTo not to duplicate the length check here
        var result = utf8Formatted.TryCopyTo(utf8Destination);
        bytesWritten = result ? utf8Formatted.Length : default;
        return result;
    }
}

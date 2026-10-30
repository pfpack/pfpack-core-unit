namespace System;

partial class UnitFormatter
{
    internal static ReadOnlySpan<byte> FormatToUtf8(ReadOnlySpan<char> format)
        =>
        InnerGetEffectiveFormat(format) switch
        {
            // Unit Canonical, JSON object, and Empty formats
            ['U' or 'u'] => "()"u8,
            ['J' or 'j'] => "{}"u8,
            ['E' or 'e'] => [],

            // Unit Canonical, JSON object, and Empty formats (Extended)
            ['U' or 'u', 'X' or 'x'] => "Unit:()"u8,
            ['J' or 'j', 'X' or 'x'] => "Unit:{}"u8,
            ['E' or 'e', 'X' or 'x'] => "Unit"u8,

            var unexpected
            =>
            throw new FormatException($"An unexpected format specifier (\"{unexpected}\").")
        };
}

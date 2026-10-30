namespace System;

partial class UnitFormatter
{
    internal static string Format(ReadOnlySpan<char> format)
        =>
        InnerGetEffectiveFormat(format) switch
        {
            // Unit Canonical, JSON object, and Empty formats
            ['U' or 'u'] => "()",
            ['J' or 'j'] => "{}",
            ['E' or 'e'] => "",

            // Unit Canonical, JSON object, and Empty formats (Extended)
            ['U' or 'u', 'X' or 'x'] => "Unit:()",
            ['J' or 'j', 'X' or 'x'] => "Unit:{}",
            ['E' or 'e', 'X' or 'x'] => "Unit",

            var unexpected
            =>
            throw new FormatException($"An unexpected format specifier (\"{unexpected}\").")
        };
}

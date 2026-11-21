using System.Runtime.CompilerServices;

namespace System;

internal static partial class UnitFormatter
{
    // Default and General format specifiers are mandatory for IFormattable
    // Default them to the Unit Canonical Extended format specifier
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static ReadOnlySpan<char> NormalizeFormat(ReadOnlySpan<char> format)
        =>
        format switch
        {
            [] or ['G' or 'g'] => ['U', 'X'],
            _ => format
        };
}

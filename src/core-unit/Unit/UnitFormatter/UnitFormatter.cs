using System.Runtime.CompilerServices;

namespace System;

internal static partial class UnitFormatter
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static ReadOnlySpan<char> InnerGetEffectiveFormat(ReadOnlySpan<char> format)
        =>
        format switch
        {
            // Default and General format specifiers are mandatory for IFormattable
            // Default them to the Unit Canonical Extended format specifier
            [] or ['G' or 'g'] => ['U', 'X'],
            _ => format
        };
}

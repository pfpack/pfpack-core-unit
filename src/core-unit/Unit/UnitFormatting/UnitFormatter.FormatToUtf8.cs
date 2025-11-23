using System.Runtime.CompilerServices;

namespace System;

partial class UnitFormatter
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static ReadOnlySpan<byte> FormatToUtf8(ReadOnlySpan<char> format)
        =>
        format switch
        {
            // General (default) form
            [] or ['G' or 'g'] => UnitFormUtf8.General,

            // Basic forms
            ['U' or 'u'] => UnitFormUtf8.Canonical,
            ['J' or 'j'] => UnitFormUtf8.JsonObj,
            ['E' or 'e'] => UnitFormUtf8.Empty,

            // Extended forms
            ['U' or 'u', 'X' or 'x'] => UnitFormUtf8.CanonicalExtended,
            ['J' or 'j', 'X' or 'x'] => UnitFormUtf8.JsonObjExtended,
            ['E' or 'e', 'X' or 'x'] => UnitFormUtf8.EmptyExtended,

            // Fallback to default
            _ => UnitFormUtf8.General
        };
}

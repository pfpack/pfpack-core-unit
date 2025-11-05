using System.Runtime.CompilerServices;

namespace System;

internal static class UnitFormatter
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static string Format(ReadOnlySpan<char> format)
        =>
        format switch
        {
            // General (default) form

            [] or ['G' or 'g'] => UnitForms.General,

            // Basic forms

            ['U' or 'u'] => UnitForms.Canonical,

            ['J' or 'j'] => UnitForms.JsonObj,

            ['E' or 'e'] => UnitForms.Empty,

            // Extended forms

            ['U' or 'u', 'X' or 'x'] => UnitForms.CanonicalExtended,

            ['J' or 'j', 'X' or 'x'] => UnitForms.JsonObjExtended,

            ['E' or 'e', 'X' or 'x'] => UnitForms.EmptyExtended,

            // Fallback to default

            _ => UnitForms.General
        };
}

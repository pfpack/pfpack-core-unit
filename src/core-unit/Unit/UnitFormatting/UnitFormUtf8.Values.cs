namespace System;

partial class UnitFormUtf8
{
    // General (default) form
    internal static ReadOnlySpan<byte> General => new(InnerGeneral.Value);

    // Basic forms
    internal static ReadOnlySpan<byte> Canonical => new(InnerCanonical.Value);
    internal static ReadOnlySpan<byte> JsonObj => new(InnerJsonObj.Value);
    internal static ReadOnlySpan<byte> Empty => new(InnerEmpty.Value);

    // Extended forms
    internal static ReadOnlySpan<byte> CanonicalExtended => new(InnerCanonicalExtended.Value);
    internal static ReadOnlySpan<byte> JsonObjExtended => new(InnerJsonObjExtended.Value);
    internal static ReadOnlySpan<byte> EmptyExtended => new(InnerEmptyExtended.Value);
}

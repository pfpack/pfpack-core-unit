namespace System;

partial class UnitFormUtf8
{
    // General (default) form
    internal static ReadOnlySpan<byte> General => InnerToSpan(InnerGeneral.Value);

    // Basic forms
    internal static ReadOnlySpan<byte> Canonical => InnerToSpan(InnerCanonical.Value);
    internal static ReadOnlySpan<byte> JsonObj => InnerToSpan(InnerJsonObj.Value);
    internal static ReadOnlySpan<byte> Empty => InnerToSpan(InnerEmpty.Value);

    // Extended forms
    internal static ReadOnlySpan<byte> CanonicalExtended => InnerToSpan(InnerCanonicalExtended.Value);
    internal static ReadOnlySpan<byte> JsonObjExtended => InnerToSpan(InnerJsonObjExtended.Value);
    internal static ReadOnlySpan<byte> EmptyExtended => InnerToSpan(InnerEmptyExtended.Value);
}

namespace System;

partial class UnitFormUtf8
{
    // General (default) form
    internal static ReadOnlySpan<byte> General => InnerAsSpan(InnerGeneral.Value);

    // Basic forms
    internal static ReadOnlySpan<byte> Canonical => InnerAsSpan(InnerCanonical.Value);
    internal static ReadOnlySpan<byte> JsonObj => InnerAsSpan(InnerJsonObj.Value);
    internal static ReadOnlySpan<byte> Empty => InnerAsSpan(InnerEmpty.Value);

    // Extended forms
    internal static ReadOnlySpan<byte> CanonicalExtended => InnerAsSpan(InnerCanonicalExtended.Value);
    internal static ReadOnlySpan<byte> JsonObjExtended => InnerAsSpan(InnerJsonObjExtended.Value);
    internal static ReadOnlySpan<byte> EmptyExtended => InnerAsSpan(InnerEmptyExtended.Value);
}

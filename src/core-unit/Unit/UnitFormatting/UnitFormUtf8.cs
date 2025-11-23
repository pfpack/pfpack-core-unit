using System.Text;

namespace System;

internal static class UnitFormUtf8
{
    // General (default) form
    internal static ReadOnlySpan<byte> General => new(InnerBytes.General);

    // Basic forms
    internal static ReadOnlySpan<byte> Canonical => new(InnerBytes.Canonical);
    internal static ReadOnlySpan<byte> JsonObj => new(InnerBytes.JsonObj);
    internal static ReadOnlySpan<byte> Empty => new(InnerBytes.Empty);

    // Extended forms
    internal static ReadOnlySpan<byte> CanonicalExtended => new(InnerBytes.CanonicalExtended);
    internal static ReadOnlySpan<byte> JsonObjExtended => new(InnerBytes.JsonObjExtended);
    internal static ReadOnlySpan<byte> EmptyExtended => new(InnerBytes.EmptyExtended);

    private static class InnerBytes
    {
        internal static readonly byte[] General = InnerGetBytes(UnitForm.General);

        internal static readonly byte[] Canonical = InnerGetBytes(UnitForm.Canonical);
        internal static readonly byte[] JsonObj = InnerGetBytes(UnitForm.JsonObj);
        internal static readonly byte[] Empty = InnerGetBytes(UnitForm.Empty);

        internal static readonly byte[] CanonicalExtended = InnerGetBytes(UnitForm.CanonicalExtended);
        internal static readonly byte[] JsonObjExtended = InnerGetBytes(UnitForm.JsonObjExtended);
        internal static readonly byte[] EmptyExtended = InnerGetBytes(UnitForm.EmptyExtended);

        private static byte[] InnerGetBytes(string s)
            =>
            Encoding.UTF8.GetBytes(s);
    }
}

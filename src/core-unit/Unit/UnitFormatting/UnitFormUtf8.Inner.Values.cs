namespace System;

partial class UnitFormUtf8
{
    // We initialize the byte arrays inline in separate classes without static ctors
    // to obtain the values lazily and at the same time independently of each other.

    // General (default) form
    private static class InnerGeneral
    {
        internal static readonly byte[] Value = InnerGetBytes(UnitForm.General);
    }

    // Basic forms
    private static class InnerCanonical
    {
        internal static readonly byte[] Value = InnerGetBytes(UnitForm.Canonical);
    }
    private static class InnerJsonObj
    {
        internal static readonly byte[] Value = InnerGetBytes(UnitForm.JsonObj);
    }
    private static class InnerEmpty
    {
        internal static readonly byte[] Value = InnerGetBytes(UnitForm.Empty);
    }

    // Extended forms
    private static class InnerCanonicalExtended
    {
        internal static readonly byte[] Value = InnerGetBytes(UnitForm.CanonicalExtended);
    }
    private static class InnerJsonObjExtended
    {
        internal static readonly byte[] Value = InnerGetBytes(UnitForm.JsonObjExtended);
    }
    private static class InnerEmptyExtended
    {
        internal static readonly byte[] Value = InnerGetBytes(UnitForm.EmptyExtended);
    }
}

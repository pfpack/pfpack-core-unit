namespace System;

partial struct Unit
{
    [Obsolete("This method is not intended for use. Call Format instead.")]
    public string ToString(string? format)
        =>
        Format(format);
}

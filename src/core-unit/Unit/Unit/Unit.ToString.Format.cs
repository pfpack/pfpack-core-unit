namespace System;

partial struct Unit
{
    [Obsolete(UnitObsoleteMessages.ToStringNotIntended_CallFormat)]
    public string ToString(string? format)
        =>
        Format(format);
}

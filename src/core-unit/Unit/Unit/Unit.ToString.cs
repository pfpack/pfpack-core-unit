#pragma warning disable CS0809 // Obsolete member overrides non-obsolete member

namespace System;

partial struct Unit
{
    [Obsolete(UnitObsoleteMessages.ToStringNotIntended_CallFormat)]
    public override string ToString()
        =>
        Format();
}

#pragma warning disable CS0809 // Obsolete member overrides non-obsolete member

using System.Diagnostics.CodeAnalysis;

namespace System;

partial struct Unit
{
    [Obsolete(UnitObsoleteMessages.EqualsObjectNotIntended_CallEqualsUnit)]
    public override bool Equals([NotNullWhen(true)] object? obj)
        =>
        obj is Unit;
}

#pragma warning disable CS0809 // Obsolete member overrides non-obsolete member

using System.Diagnostics.CodeAnalysis;

namespace System;

partial struct Unit
{
    [Obsolete($"This method is not intended for use. Call Equals(Unit) instead.")]
    public override bool Equals([NotNullWhen(true)] object? obj)
        =>
        obj is Unit;
}

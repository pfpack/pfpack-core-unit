using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace System;

partial struct Unit
{
    public bool Equals(Unit other) => true;

    public override bool Equals([NotNullWhen(true)] object? obj)
        =>
        obj is Unit;

    public override int GetHashCode()
        =>
        HashCode.Combine(EqualityComparer<Type>.Default.GetHashCode(typeof(Unit)));
}

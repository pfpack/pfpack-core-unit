using System.Collections.Generic;

namespace System;

partial struct Unit
{
    public bool Equals(Unit other) => true;

    public override int GetHashCode()
        =>
        HashCode.Combine(
            EqualityComparer<Type>.Default.GetHashCode(typeof(Unit)));
}

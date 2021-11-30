#pragma warning disable IDE0060 // Remove unused parameter

namespace System;

partial struct Unit
{
    public static bool Equals(Unit left, Unit right) => true;

    public static bool operator ==(Unit left, Unit right) => true;

    public static bool operator !=(Unit left, Unit right) => false;
}

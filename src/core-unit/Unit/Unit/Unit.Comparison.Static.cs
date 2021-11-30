#pragma warning disable IDE0060 // Remove unused parameter

namespace System;

partial struct Unit
{
    public static int Compare(Unit left, Unit right) => default;

    public static bool operator <=(Unit left, Unit right) => true;

    public static bool operator >=(Unit left, Unit right) => true;

    public static bool operator <(Unit left, Unit right) => false;

    public static bool operator >(Unit left, Unit right) => false;
}

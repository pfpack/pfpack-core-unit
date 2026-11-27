namespace System;

partial struct Unit
{
    public static bool operator <=(Unit left, Unit right) => true;

    public static bool operator >=(Unit left, Unit right) => true;

    public static bool operator <(Unit left, Unit right) => false;

    public static bool operator >(Unit left, Unit right) => false;
}

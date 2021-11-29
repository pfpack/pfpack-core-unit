namespace System;

partial struct Unit
{
    public int CompareTo(Unit other) => 0;

    public int CompareTo(object? obj) => obj switch
    {
        null => 1,
        Unit => 0,
        _ => throw new ArgumentException("The object is not the Unit.", nameof(obj))
    };

    public static int Compare(Unit left, Unit right) => (left, right) switch
    {
        _ => 0
    };

    public static bool operator <=(Unit left, Unit right) => (left, right) switch
    {
        _ => true
    };

    public static bool operator >=(Unit left, Unit right) => (left, right) switch
    {
        _ => true
    };

    public static bool operator <(Unit left, Unit right) => (left, right) switch
    {
        _ => false
    };

    public static bool operator >(Unit left, Unit right) => (left, right) switch
    {
        _ => false
    };
}

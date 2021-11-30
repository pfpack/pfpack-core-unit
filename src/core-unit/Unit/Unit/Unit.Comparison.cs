namespace System;

partial struct Unit
{
    public int CompareTo(Unit other) => default;

    public int CompareTo(object? obj) => obj switch
    {
        null => 1,

        Unit => default,

        _ => throw new ArgumentException("The object is not Unit.", nameof(obj))
    };
}

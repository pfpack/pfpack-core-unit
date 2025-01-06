namespace System;

// TODO: Remove Nongeneric IComparable declaration/implementation in v4.0
partial struct Unit : IComparable
{
    [Obsolete("This method is obsolete. Call CompareTo(Unit) instead.")]
    public int CompareTo(object? obj) => obj switch
    {
        null => 1,
        Unit => default,
        _ => throw new ArgumentException($"Object must be of type {nameof(Unit)}.", nameof(obj))
    };
}

namespace System;

partial struct Unit
{
    public override string ToString()
        =>
        InnerFormat(default);
}

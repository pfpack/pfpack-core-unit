namespace System;

partial class UnitExtensions
{
    // TODO: Remove the obsoletes in v3.0

    private const string ObsoleteMessage_InvokeThenToUnit = "This method is obsolete. Call InvokeAsFunc instead.";

    [Obsolete(ObsoleteMessage_InvokeThenToUnit, error: true)]
    public static Unit InvokeThenToUnit(
        this Action action)
        =>
        action.InvokeAsFunc();

    [Obsolete(ObsoleteMessage_InvokeThenToUnit, error: true)]
    public static Unit InvokeThenToUnit<T>(
        this Action<T> action,
        T obj)
        =>
        action.InvokeAsFunc(obj);

    [Obsolete(ObsoleteMessage_InvokeThenToUnit, error: true)]
    public static Unit InvokeThenToUnit<T1, T2>(
        this Action<T1, T2> action,
        T1 arg1,
        T2 arg2)
        =>
        action.InvokeAsFunc(
            arg1,
            arg2);

    [Obsolete(ObsoleteMessage_InvokeThenToUnit, error: true)]
    public static Unit InvokeThenToUnit<T1, T2, T3>(
        this Action<T1, T2, T3> action,
        T1 arg1,
        T2 arg2,
        T3 arg3)
        =>
        action.InvokeAsFunc(
            arg1,
            arg2,
            arg3);

    [Obsolete(ObsoleteMessage_InvokeThenToUnit, error: true)]
    public static Unit InvokeThenToUnit<T1, T2, T3, T4>(
        this Action<T1, T2, T3, T4> action,
        T1 arg1,
        T2 arg2,
        T3 arg3,
        T4 arg4)
        =>
        action.InvokeAsFunc(
            arg1,
            arg2,
            arg3,
            arg4);

    [Obsolete(ObsoleteMessage_InvokeThenToUnit, error: true)]
    public static Unit InvokeThenToUnit<T1, T2, T3, T4, T5>(
        this Action<T1, T2, T3, T4, T5> action,
        T1 arg1,
        T2 arg2,
        T3 arg3,
        T4 arg4,
        T5 arg5)
        =>
        action.InvokeAsFunc(
            arg1,
            arg2,
            arg3,
            arg4,
            arg5);

    [Obsolete(ObsoleteMessage_InvokeThenToUnit, error: true)]
    public static Unit InvokeThenToUnit<T1, T2, T3, T4, T5, T6>(
        this Action<T1, T2, T3, T4, T5, T6> action,
        T1 arg1,
        T2 arg2,
        T3 arg3,
        T4 arg4,
        T5 arg5,
        T6 arg6)
        =>
        action.InvokeAsFunc(
            arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6);

    [Obsolete(ObsoleteMessage_InvokeThenToUnit, error: true)]
    public static Unit InvokeThenToUnit<T1, T2, T3, T4, T5, T6, T7>(
        this Action<T1, T2, T3, T4, T5, T6, T7> action,
        T1 arg1,
        T2 arg2,
        T3 arg3,
        T4 arg4,
        T5 arg5,
        T6 arg6,
        T7 arg7)
        =>
        action.InvokeAsFunc(
            arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6,
            arg7);

    [Obsolete(ObsoleteMessage_InvokeThenToUnit, error: true)]
    public static Unit InvokeThenToUnit<T1, T2, T3, T4, T5, T6, T7, T8>(
        this Action<T1, T2, T3, T4, T5, T6, T7, T8> action,
        T1 arg1,
        T2 arg2,
        T3 arg3,
        T4 arg4,
        T5 arg5,
        T6 arg6,
        T7 arg7,
        T8 arg8)
        =>
        action.InvokeAsFunc(
            arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6,
            arg7,
            arg8);

    [Obsolete(ObsoleteMessage_InvokeThenToUnit, error: true)]
    public static Unit InvokeThenToUnit<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
        this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action,
        T1 arg1,
        T2 arg2,
        T3 arg3,
        T4 arg4,
        T5 arg5,
        T6 arg6,
        T7 arg7,
        T8 arg8,
        T9 arg9)
        =>
        action.InvokeAsFunc(
            arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6,
            arg7,
            arg8,
            arg9);

    [Obsolete(ObsoleteMessage_InvokeThenToUnit, error: true)]
    public static Unit InvokeThenToUnit<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
        this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action,
        T1 arg1,
        T2 arg2,
        T3 arg3,
        T4 arg4,
        T5 arg5,
        T6 arg6,
        T7 arg7,
        T8 arg8,
        T9 arg9,
        T10 arg10)
        =>
        action.InvokeAsFunc(
            arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6,
            arg7,
            arg8,
            arg9,
            arg10);

    [Obsolete(ObsoleteMessage_InvokeThenToUnit, error: true)]
    public static Unit InvokeThenToUnit<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
        this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action,
        T1 arg1,
        T2 arg2,
        T3 arg3,
        T4 arg4,
        T5 arg5,
        T6 arg6,
        T7 arg7,
        T8 arg8,
        T9 arg9,
        T10 arg10,
        T11 arg11)
        =>
        action.InvokeAsFunc(
            arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6,
            arg7,
            arg8,
            arg9,
            arg10,
            arg11);

    [Obsolete(ObsoleteMessage_InvokeThenToUnit, error: true)]
    public static Unit InvokeThenToUnit<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
        this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action,
        T1 arg1,
        T2 arg2,
        T3 arg3,
        T4 arg4,
        T5 arg5,
        T6 arg6,
        T7 arg7,
        T8 arg8,
        T9 arg9,
        T10 arg10,
        T11 arg11,
        T12 arg12)
        =>
        action.InvokeAsFunc(
            arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6,
            arg7,
            arg8,
            arg9,
            arg10,
            arg11,
            arg12);

    [Obsolete(ObsoleteMessage_InvokeThenToUnit, error: true)]
    public static Unit InvokeThenToUnit<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
        this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action,
        T1 arg1,
        T2 arg2,
        T3 arg3,
        T4 arg4,
        T5 arg5,
        T6 arg6,
        T7 arg7,
        T8 arg8,
        T9 arg9,
        T10 arg10,
        T11 arg11,
        T12 arg12,
        T13 arg13)
        =>
        action.InvokeAsFunc(
            arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6,
            arg7,
            arg8,
            arg9,
            arg10,
            arg11,
            arg12,
            arg13);

    [Obsolete(ObsoleteMessage_InvokeThenToUnit, error: true)]
    public static Unit InvokeThenToUnit<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
        this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action,
        T1 arg1,
        T2 arg2,
        T3 arg3,
        T4 arg4,
        T5 arg5,
        T6 arg6,
        T7 arg7,
        T8 arg8,
        T9 arg9,
        T10 arg10,
        T11 arg11,
        T12 arg12,
        T13 arg13,
        T14 arg14)
        =>
        action.InvokeAsFunc(
            arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6,
            arg7,
            arg8,
            arg9,
            arg10,
            arg11,
            arg12,
            arg13,
            arg14);

    [Obsolete(ObsoleteMessage_InvokeThenToUnit, error: true)]
    public static Unit InvokeThenToUnit<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
        this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action,
        T1 arg1,
        T2 arg2,
        T3 arg3,
        T4 arg4,
        T5 arg5,
        T6 arg6,
        T7 arg7,
        T8 arg8,
        T9 arg9,
        T10 arg10,
        T11 arg11,
        T12 arg12,
        T13 arg13,
        T14 arg14,
        T15 arg15)
        =>
        action.InvokeAsFunc(
            arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6,
            arg7,
            arg8,
            arg9,
            arg10,
            arg11,
            arg12,
            arg13,
            arg14,
            arg15);

    [Obsolete(ObsoleteMessage_InvokeThenToUnit, error: true)]
    public static Unit InvokeThenToUnit<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
        this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action,
        T1 arg1,
        T2 arg2,
        T3 arg3,
        T4 arg4,
        T5 arg5,
        T6 arg6,
        T7 arg7,
        T8 arg8,
        T9 arg9,
        T10 arg10,
        T11 arg11,
        T12 arg12,
        T13 arg13,
        T14 arg14,
        T15 arg15,
        T16 arg16)
        =>
        action.InvokeAsFunc(
            arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6,
            arg7,
            arg8,
            arg9,
            arg10,
            arg11,
            arg12,
            arg13,
            arg14,
            arg15,
            arg16);
}

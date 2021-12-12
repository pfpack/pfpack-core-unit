using static System.InternalInvoker;

namespace System;

partial struct Unit
{
    public static Unit Invoke(
        Action action)
        =>
        InternalInvoke(
            action ?? throw new ArgumentNullException(nameof(action)));

    public static Unit Invoke<T>(
        Action<T> action,
        T obj)
        =>
        InternalInvoke(
            action ?? throw new ArgumentNullException(nameof(action)),
            obj);

    public static Unit Invoke<T1, T2>(
        Action<T1, T2> action,
        T1 arg1,
        T2 arg2)
        =>
        InternalInvoke(
            action ?? throw new ArgumentNullException(nameof(action)),
            arg1,
            arg2);

    public static Unit Invoke<T1, T2, T3>(
        Action<T1, T2, T3> action,
        T1 arg1,
        T2 arg2,
        T3 arg3)
        =>
        InternalInvoke(
            action ?? throw new ArgumentNullException(nameof(action)),
            arg1,
            arg2,
            arg3);

    public static Unit Invoke<T1, T2, T3, T4>(
        Action<T1, T2, T3, T4> action,
        T1 arg1,
        T2 arg2,
        T3 arg3,
        T4 arg4)
        =>
        InternalInvoke(
            action ?? throw new ArgumentNullException(nameof(action)),
            arg1,
            arg2,
            arg3,
            arg4);

    public static Unit Invoke<T1, T2, T3, T4, T5>(
        Action<T1, T2, T3, T4, T5> action,
        T1 arg1,
        T2 arg2,
        T3 arg3,
        T4 arg4,
        T5 arg5)
        =>
        InternalInvoke(
            action ?? throw new ArgumentNullException(nameof(action)),
            arg1,
            arg2,
            arg3,
            arg4,
            arg5);

    public static Unit Invoke<T1, T2, T3, T4, T5, T6>(
        Action<T1, T2, T3, T4, T5, T6> action,
        T1 arg1,
        T2 arg2,
        T3 arg3,
        T4 arg4,
        T5 arg5,
        T6 arg6)
        =>
        InternalInvoke(
            action ?? throw new ArgumentNullException(nameof(action)),
            arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6);

    public static Unit Invoke<T1, T2, T3, T4, T5, T6, T7>(
        Action<T1, T2, T3, T4, T5, T6, T7> action,
        T1 arg1,
        T2 arg2,
        T3 arg3,
        T4 arg4,
        T5 arg5,
        T6 arg6,
        T7 arg7)
        =>
        InternalInvoke(
            action ?? throw new ArgumentNullException(nameof(action)),
            arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6,
            arg7);

    public static Unit Invoke<T1, T2, T3, T4, T5, T6, T7, T8>(
        Action<T1, T2, T3, T4, T5, T6, T7, T8> action,
        T1 arg1,
        T2 arg2,
        T3 arg3,
        T4 arg4,
        T5 arg5,
        T6 arg6,
        T7 arg7,
        T8 arg8)
        =>
        InternalInvoke(
            action ?? throw new ArgumentNullException(nameof(action)),
            arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6,
            arg7,
            arg8);

    public static Unit Invoke<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action,
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
        InternalInvoke(
            action ?? throw new ArgumentNullException(nameof(action)),
            arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6,
            arg7,
            arg8,
            arg9);

    public static Unit Invoke<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action,
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
        InternalInvoke(
            action ?? throw new ArgumentNullException(nameof(action)),
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

    public static Unit Invoke<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action,
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
        InternalInvoke(
            action ?? throw new ArgumentNullException(nameof(action)),
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

    public static Unit Invoke<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action,
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
        InternalInvoke(
            action ?? throw new ArgumentNullException(nameof(action)),
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

    public static Unit Invoke<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action,
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
        InternalInvoke(
            action ?? throw new ArgumentNullException(nameof(action)),
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

    public static Unit Invoke<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action,
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
        InternalInvoke(
            action ?? throw new ArgumentNullException(nameof(action)),
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

    public static Unit Invoke<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action,
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
        InternalInvoke(
            action ?? throw new ArgumentNullException(nameof(action)),
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

    public static Unit Invoke<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action,
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
        InternalInvoke(
            action ?? throw new ArgumentNullException(nameof(action)),
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

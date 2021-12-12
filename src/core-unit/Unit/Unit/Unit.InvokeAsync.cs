using static System.InternalInvoker;

using System.Threading.Tasks;

namespace System;

partial struct Unit
{
    public static Task<Unit> InvokeAsync(
        Func<Task> funcAsync)
        =>
        InternalInvokeAsync(
            funcAsync ?? throw new ArgumentNullException(nameof(funcAsync)));

    public static Task<Unit> InvokeAsync<T>(
        Func<T, Task> funcAsync,
        T obj)
        =>
        InternalInvokeAsync(
            funcAsync ?? throw new ArgumentNullException(nameof(funcAsync)),
            obj);

    public static Task<Unit> InvokeAsync<T1, T2>(
        Func<T1, T2, Task> funcAsync,
        T1 arg1,
        T2 arg2)
        =>
        InternalInvokeAsync(
            funcAsync ?? throw new ArgumentNullException(nameof(funcAsync)),
            arg1,
            arg2);

    public static Task<Unit> InvokeAsync<T1, T2, T3>(
        Func<T1, T2, T3, Task> funcAsync,
        T1 arg1,
        T2 arg2,
        T3 arg3)
        =>
        InternalInvokeAsync(
            funcAsync ?? throw new ArgumentNullException(nameof(funcAsync)),
            arg1,
            arg2,
            arg3);

    public static Task<Unit> InvokeAsync<T1, T2, T3, T4>(
        Func<T1, T2, T3, T4, Task> funcAsync,
        T1 arg1,
        T2 arg2,
        T3 arg3,
        T4 arg4)
        =>
        InternalInvokeAsync(
            funcAsync ?? throw new ArgumentNullException(nameof(funcAsync)),
            arg1,
            arg2,
            arg3,
            arg4);

    public static Task<Unit> InvokeAsync<T1, T2, T3, T4, T5>(
        Func<T1, T2, T3, T4, T5, Task> funcAsync,
        T1 arg1,
        T2 arg2,
        T3 arg3,
        T4 arg4,
        T5 arg5)
        =>
        InternalInvokeAsync(
            funcAsync ?? throw new ArgumentNullException(nameof(funcAsync)),
            arg1,
            arg2,
            arg3,
            arg4,
            arg5);

    public static Task<Unit> InvokeAsync<T1, T2, T3, T4, T5, T6>(
        Func<T1, T2, T3, T4, T5, T6, Task> funcAsync,
        T1 arg1,
        T2 arg2,
        T3 arg3,
        T4 arg4,
        T5 arg5,
        T6 arg6)
        =>
        InternalInvokeAsync(
            funcAsync ?? throw new ArgumentNullException(nameof(funcAsync)),
            arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6);

    public static Task<Unit> InvokeAsync<T1, T2, T3, T4, T5, T6, T7>(
        Func<T1, T2, T3, T4, T5, T6, T7, Task> funcAsync,
        T1 arg1,
        T2 arg2,
        T3 arg3,
        T4 arg4,
        T5 arg5,
        T6 arg6,
        T7 arg7)
        =>
        InternalInvokeAsync(
            funcAsync ?? throw new ArgumentNullException(nameof(funcAsync)),
            arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6,
            arg7);

    public static Task<Unit> InvokeAsync<T1, T2, T3, T4, T5, T6, T7, T8>(
        Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> funcAsync,
        T1 arg1,
        T2 arg2,
        T3 arg3,
        T4 arg4,
        T5 arg5,
        T6 arg6,
        T7 arg7,
        T8 arg8)
        =>
        InternalInvokeAsync(
            funcAsync ?? throw new ArgumentNullException(nameof(funcAsync)),
            arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6,
            arg7,
            arg8);

    public static Task<Unit> InvokeAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task> funcAsync,
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
        InternalInvokeAsync(
            funcAsync ?? throw new ArgumentNullException(nameof(funcAsync)),
            arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6,
            arg7,
            arg8,
            arg9);

    public static Task<Unit> InvokeAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task> funcAsync,
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
        InternalInvokeAsync(
            funcAsync ?? throw new ArgumentNullException(nameof(funcAsync)),
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

    public static Task<Unit> InvokeAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task> funcAsync,
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
        InternalInvokeAsync(
            funcAsync ?? throw new ArgumentNullException(nameof(funcAsync)),
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

    public static Task<Unit> InvokeAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task> funcAsync,
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
        InternalInvokeAsync(
            funcAsync ?? throw new ArgumentNullException(nameof(funcAsync)),
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

    public static Task<Unit> InvokeAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task> funcAsync,
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
        InternalInvokeAsync(
            funcAsync ?? throw new ArgumentNullException(nameof(funcAsync)),
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

    public static Task<Unit> InvokeAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task> funcAsync,
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
        InternalInvokeAsync(
            funcAsync ?? throw new ArgumentNullException(nameof(funcAsync)),
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

    public static Task<Unit> InvokeAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task> funcAsync,
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
        InternalInvokeAsync(
            funcAsync ?? throw new ArgumentNullException(nameof(funcAsync)),
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

    public static Task<Unit> InvokeAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task> funcAsync,
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
        InternalInvokeAsync(
            funcAsync ?? throw new ArgumentNullException(nameof(funcAsync)),
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

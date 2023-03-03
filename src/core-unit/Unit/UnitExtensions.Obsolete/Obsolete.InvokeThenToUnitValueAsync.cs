using System.Threading.Tasks;

namespace System;

partial class UnitExtensions
{
    // TODO: Remove the obsoletes on v3.0

    private const string ObsoleteMessage_InvokeThenToUnitValueAsync = "This method is obsolete. Call InvokeAsFuncValueAsync instead.";

    [Obsolete(ObsoleteMessage_InvokeThenToUnitValueAsync, error: true)]
    public static ValueTask<Unit> InvokeThenToUnitValueAsync(
        this Func<ValueTask> funcAsync)
        =>
        funcAsync.InvokeAsFuncValueAsync();

    [Obsolete(ObsoleteMessage_InvokeThenToUnitValueAsync, error: true)]
    public static ValueTask<Unit> InvokeThenToUnitValueAsync<T>(
        this Func<T, ValueTask> funcAsync,
        T obj)
        =>
        funcAsync.InvokeAsFuncValueAsync(obj);

    [Obsolete(ObsoleteMessage_InvokeThenToUnitValueAsync, error: true)]
    public static ValueTask<Unit> InvokeThenToUnitValueAsync<T1, T2>(
        this Func<T1, T2, ValueTask> funcAsync,
        T1 arg1,
        T2 arg2)
        =>
        funcAsync.InvokeAsFuncValueAsync(
            arg1,
            arg2);

    [Obsolete(ObsoleteMessage_InvokeThenToUnitValueAsync, error: true)]
    public static ValueTask<Unit> InvokeThenToUnitValueAsync<T1, T2, T3>(
        this Func<T1, T2, T3, ValueTask> funcAsync,
        T1 arg1,
        T2 arg2,
        T3 arg3)
        =>
        funcAsync.InvokeAsFuncValueAsync(
            arg1,
            arg2,
            arg3);

    [Obsolete(ObsoleteMessage_InvokeThenToUnitValueAsync, error: true)]
    public static ValueTask<Unit> InvokeThenToUnitValueAsync<T1, T2, T3, T4>(
        this Func<T1, T2, T3, T4, ValueTask> funcAsync,
        T1 arg1,
        T2 arg2,
        T3 arg3,
        T4 arg4)
        =>
        funcAsync.InvokeAsFuncValueAsync(
            arg1,
            arg2,
            arg3,
            arg4);

    [Obsolete(ObsoleteMessage_InvokeThenToUnitValueAsync, error: true)]
    public static ValueTask<Unit> InvokeThenToUnitValueAsync<T1, T2, T3, T4, T5>(
        this Func<T1, T2, T3, T4, T5, ValueTask> funcAsync,
        T1 arg1,
        T2 arg2,
        T3 arg3,
        T4 arg4,
        T5 arg5)
        =>
        funcAsync.InvokeAsFuncValueAsync(
            arg1,
            arg2,
            arg3,
            arg4,
            arg5);

    [Obsolete(ObsoleteMessage_InvokeThenToUnitValueAsync, error: true)]
    public static ValueTask<Unit> InvokeThenToUnitValueAsync<T1, T2, T3, T4, T5, T6>(
        this Func<T1, T2, T3, T4, T5, T6, ValueTask> funcAsync,
        T1 arg1,
        T2 arg2,
        T3 arg3,
        T4 arg4,
        T5 arg5,
        T6 arg6)
        =>
        funcAsync.InvokeAsFuncValueAsync(
            arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6);

    [Obsolete(ObsoleteMessage_InvokeThenToUnitValueAsync, error: true)]
    public static ValueTask<Unit> InvokeThenToUnitValueAsync<T1, T2, T3, T4, T5, T6, T7>(
        this Func<T1, T2, T3, T4, T5, T6, T7, ValueTask> funcAsync,
        T1 arg1,
        T2 arg2,
        T3 arg3,
        T4 arg4,
        T5 arg5,
        T6 arg6,
        T7 arg7)
        =>
        funcAsync.InvokeAsFuncValueAsync(
            arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6,
            arg7);

    [Obsolete(ObsoleteMessage_InvokeThenToUnitValueAsync, error: true)]
    public static ValueTask<Unit> InvokeThenToUnitValueAsync<T1, T2, T3, T4, T5, T6, T7, T8>(
        this Func<T1, T2, T3, T4, T5, T6, T7, T8, ValueTask> funcAsync,
        T1 arg1,
        T2 arg2,
        T3 arg3,
        T4 arg4,
        T5 arg5,
        T6 arg6,
        T7 arg7,
        T8 arg8)
        =>
        funcAsync.InvokeAsFuncValueAsync(
            arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6,
            arg7,
            arg8);

    [Obsolete(ObsoleteMessage_InvokeThenToUnitValueAsync, error: true)]
    public static ValueTask<Unit> InvokeThenToUnitValueAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
        this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, ValueTask> funcAsync,
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
        funcAsync.InvokeAsFuncValueAsync(
            arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6,
            arg7,
            arg8,
            arg9);

    [Obsolete(ObsoleteMessage_InvokeThenToUnitValueAsync, error: true)]
    public static ValueTask<Unit> InvokeThenToUnitValueAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
        this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, ValueTask> funcAsync,
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
        funcAsync.InvokeAsFuncValueAsync(
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

    [Obsolete(ObsoleteMessage_InvokeThenToUnitValueAsync, error: true)]
    public static ValueTask<Unit> InvokeThenToUnitValueAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
        this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, ValueTask> funcAsync,
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
        funcAsync.InvokeAsFuncValueAsync(
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

    [Obsolete(ObsoleteMessage_InvokeThenToUnitValueAsync, error: true)]
    public static ValueTask<Unit> InvokeThenToUnitValueAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
        this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, ValueTask> funcAsync,
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
        funcAsync.InvokeAsFuncValueAsync(
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

    [Obsolete(ObsoleteMessage_InvokeThenToUnitValueAsync, error: true)]
    public static ValueTask<Unit> InvokeThenToUnitValueAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
        this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, ValueTask> funcAsync,
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
        funcAsync.InvokeAsFuncValueAsync(
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

    [Obsolete(ObsoleteMessage_InvokeThenToUnitValueAsync, error: true)]
    public static ValueTask<Unit> InvokeThenToUnitValueAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
        this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, ValueTask> funcAsync,
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
        funcAsync.InvokeAsFuncValueAsync(
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

    [Obsolete(ObsoleteMessage_InvokeThenToUnitValueAsync, error: true)]
    public static ValueTask<Unit> InvokeThenToUnitValueAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
        this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, ValueTask> funcAsync,
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
        funcAsync.InvokeAsFuncValueAsync(
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

    [Obsolete(ObsoleteMessage_InvokeThenToUnitValueAsync, error: true)]
    public static ValueTask<Unit> InvokeThenToUnitValueAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
        this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, ValueTask> funcAsync,
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
        funcAsync.InvokeAsFuncValueAsync(
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

using System.Threading.Tasks;

namespace System;

partial class InternalInvoker
{
    internal static async Task<Unit> InvokeAsync(Func<Task> funcAsync)
    {
        await funcAsync.Invoke().ConfigureAwait(false);

        return default;
    }

    internal static async Task<Unit> InvokeAsync<T>(Func<T, Task> funcAsync, T obj)
    {
        await funcAsync.Invoke(obj).ConfigureAwait(false);

        return default;
    }

    internal static async Task<Unit> InvokeAsync<T1, T2>(
        Func<T1, T2, Task> funcAsync,
        T1 arg1,
        T2 arg2)
    {
        await funcAsync.Invoke(
            arg1,
            arg2)
            .ConfigureAwait(false);

        return default;
    }

    internal static async Task<Unit> InvokeAsync<T1, T2, T3>(
        Func<T1, T2, T3, Task> funcAsync,
        T1 arg1,
        T2 arg2,
        T3 arg3)
    {
        await funcAsync.Invoke(
            arg1,
            arg2,
            arg3)
            .ConfigureAwait(false);

        return default;
    }

    internal static async Task<Unit> InvokeAsync<T1, T2, T3, T4>(
        Func<T1, T2, T3, T4, Task> funcAsync,
        T1 arg1,
        T2 arg2,
        T3 arg3,
        T4 arg4)
    {
        await funcAsync.Invoke(
            arg1,
            arg2,
            arg3,
            arg4)
            .ConfigureAwait(false);

        return default;
    }

    internal static async Task<Unit> InvokeAsync<T1, T2, T3, T4, T5>(
        Func<T1, T2, T3, T4, T5, Task> funcAsync,
        T1 arg1,
        T2 arg2,
        T3 arg3,
        T4 arg4,
        T5 arg5)
    {
        await funcAsync.Invoke(
            arg1,
            arg2,
            arg3,
            arg4,
            arg5)
            .ConfigureAwait(false);

        return default;
    }

    internal static async Task<Unit> InvokeAsync<T1, T2, T3, T4, T5, T6>(
        Func<T1, T2, T3, T4, T5, T6, Task> funcAsync,
        T1 arg1,
        T2 arg2,
        T3 arg3,
        T4 arg4,
        T5 arg5,
        T6 arg6)
    {
        await funcAsync.Invoke(
            arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6)
            .ConfigureAwait(false);

        return default;
    }

    internal static async Task<Unit> InvokeAsync<T1, T2, T3, T4, T5, T6, T7>(
        Func<T1, T2, T3, T4, T5, T6, T7, Task> funcAsync,
        T1 arg1,
        T2 arg2,
        T3 arg3,
        T4 arg4,
        T5 arg5,
        T6 arg6,
        T7 arg7)
    {
        await funcAsync.Invoke(
            arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6,
            arg7)
            .ConfigureAwait(false);

        return default;
    }

    internal static async Task<Unit> InvokeAsync<T1, T2, T3, T4, T5, T6, T7, T8>(
        Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> funcAsync,
        T1 arg1,
        T2 arg2,
        T3 arg3,
        T4 arg4,
        T5 arg5,
        T6 arg6,
        T7 arg7,
        T8 arg8)
    {
        await funcAsync.Invoke(
            arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6,
            arg7,
            arg8)
            .ConfigureAwait(false);

        return default;
    }

    internal static async Task<Unit> InvokeAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
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
    {
        await funcAsync.Invoke(
            arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6,
            arg7,
            arg8,
            arg9)
            .ConfigureAwait(false);

        return default;
    }

    internal static async Task<Unit> InvokeAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
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
    {
        await funcAsync.Invoke(
            arg1,
            arg2,
            arg3,
            arg4,
            arg5,
            arg6,
            arg7,
            arg8,
            arg9,
            arg10)
            .ConfigureAwait(false);

        return default;
    }

    internal static async Task<Unit> InvokeAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
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
    {
        await funcAsync.Invoke(
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
            arg11)
            .ConfigureAwait(false);

        return default;
    }

    internal static async Task<Unit> InvokeAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
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
    {
        await funcAsync.Invoke(
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
            arg12)
            .ConfigureAwait(false);

        return default;
    }

    internal static async Task<Unit> InvokeAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
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
    {
        await funcAsync.Invoke(
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
            arg13)
            .ConfigureAwait(false);

        return default;
    }

    internal static async Task<Unit> InvokeAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
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
    {
        await funcAsync.Invoke(
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
            arg14)
            .ConfigureAwait(false);

        return default;
    }

    internal static async Task<Unit> InvokeAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
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
    {
        await funcAsync.Invoke(
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
            arg15)
            .ConfigureAwait(false);

        return default;
    }

    internal static async Task<Unit> InvokeAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
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
    {
        await funcAsync.Invoke(
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
            arg16)
            .ConfigureAwait(false);

        return default;
    }
}

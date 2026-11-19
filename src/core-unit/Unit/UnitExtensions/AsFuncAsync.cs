using System.Threading.Tasks;

namespace System;

partial class UnitExtensions
{
    public static Func<Task<Unit>> AsFuncAsync(
        this Func<Task> funcAsync)
    {
        _ = funcAsync ?? throw new ArgumentNullException(nameof(funcAsync));

        return async () =>
        {
            await funcAsync.Invoke().ConfigureAwait(AwaitOptions);

            return default;
        };
    }

    public static Func<Task<Unit>> AsFuncAsync<T>(
        this Func<T, Task> funcAsync,
        T arg)
    {
        _ = funcAsync ?? throw new ArgumentNullException(nameof(funcAsync));

        return async () =>
        {
            await funcAsync.Invoke(arg).ConfigureAwait(AwaitOptions);

            return default;
        };
    }

    public static Func<Task<Unit>> AsFuncAsync<T1, T2>(
        this Func<T1, T2, Task> funcAsync,
        T1 arg1,
        T2 arg2)
    {
        _ = funcAsync ?? throw new ArgumentNullException(nameof(funcAsync));

        return async () =>
        {
            await funcAsync.Invoke(
                arg1,
                arg2).ConfigureAwait(AwaitOptions);

            return default;
        };
    }

    public static Func<Task<Unit>> AsFuncAsync<T1, T2, T3>(
        this Func<T1, T2, T3, Task> funcAsync,
        T1 arg1,
        T2 arg2,
        T3 arg3)
    {
        _ = funcAsync ?? throw new ArgumentNullException(nameof(funcAsync));

        return async () =>
        {
            await funcAsync.Invoke(
                arg1,
                arg2,
                arg3).ConfigureAwait(AwaitOptions);

            return default;
        };
    }

    public static Func<Task<Unit>> AsFuncAsync<T1, T2, T3, T4>(
        this Func<T1, T2, T3, T4, Task> funcAsync,
        T1 arg1,
        T2 arg2,
        T3 arg3,
        T4 arg4)
    {
        _ = funcAsync ?? throw new ArgumentNullException(nameof(funcAsync));

        return async () =>
        {
            await funcAsync.Invoke(
                arg1,
                arg2,
                arg3,
                arg4).ConfigureAwait(AwaitOptions);

            return default;
        };
    }

    public static Func<Task<Unit>> AsFuncAsync<T1, T2, T3, T4, T5>(
        this Func<T1, T2, T3, T4, T5, Task> funcAsync,
        T1 arg1,
        T2 arg2,
        T3 arg3,
        T4 arg4,
        T5 arg5)
    {
        _ = funcAsync ?? throw new ArgumentNullException(nameof(funcAsync));

        return async () =>
        {
            await funcAsync.Invoke(
                arg1,
                arg2,
                arg3,
                arg4,
                arg5).ConfigureAwait(AwaitOptions);

            return default;
        };
    }

    public static Func<Task<Unit>> AsFuncAsync<T1, T2, T3, T4, T5, T6>(
        this Func<T1, T2, T3, T4, T5, T6, Task> funcAsync,
        T1 arg1,
        T2 arg2,
        T3 arg3,
        T4 arg4,
        T5 arg5,
        T6 arg6)
    {
        _ = funcAsync ?? throw new ArgumentNullException(nameof(funcAsync));

        return async () =>
        {
            await funcAsync.Invoke(
                arg1,
                arg2,
                arg3,
                arg4,
                arg5,
                arg6).ConfigureAwait(AwaitOptions);

            return default;
        };
    }

    public static Func<Task<Unit>> AsFuncAsync<T1, T2, T3, T4, T5, T6, T7>(
        this Func<T1, T2, T3, T4, T5, T6, T7, Task> funcAsync,
        T1 arg1,
        T2 arg2,
        T3 arg3,
        T4 arg4,
        T5 arg5,
        T6 arg6,
        T7 arg7)
    {
        _ = funcAsync ?? throw new ArgumentNullException(nameof(funcAsync));

        return async () =>
        {
            await funcAsync.Invoke(
                arg1,
                arg2,
                arg3,
                arg4,
                arg5,
                arg6,
                arg7).ConfigureAwait(AwaitOptions);

            return default;
        };
    }

    public static Func<Task<Unit>> AsFuncAsync<T1, T2, T3, T4, T5, T6, T7, T8>(
        this Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> funcAsync,
        T1 arg1,
        T2 arg2,
        T3 arg3,
        T4 arg4,
        T5 arg5,
        T6 arg6,
        T7 arg7,
        T8 arg8)
    {
        _ = funcAsync ?? throw new ArgumentNullException(nameof(funcAsync));

        return async () =>
        {
            await funcAsync.Invoke(
                arg1,
                arg2,
                arg3,
                arg4,
                arg5,
                arg6,
                arg7,
                arg8).ConfigureAwait(AwaitOptions);

            return default;
        };
    }

    public static Func<Task<Unit>> AsFuncAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
        this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task> funcAsync,
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
        _ = funcAsync ?? throw new ArgumentNullException(nameof(funcAsync));

        return async () =>
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
                arg9).ConfigureAwait(AwaitOptions);

            return default;
        };
    }

    public static Func<Task<Unit>> AsFuncAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
        this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task> funcAsync,
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
        _ = funcAsync ?? throw new ArgumentNullException(nameof(funcAsync));

        return async () =>
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
                arg10).ConfigureAwait(AwaitOptions);

            return default;
        };
    }

    public static Func<Task<Unit>> AsFuncAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
        this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task> funcAsync,
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
        _ = funcAsync ?? throw new ArgumentNullException(nameof(funcAsync));

        return async () =>
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
                arg11).ConfigureAwait(AwaitOptions);

            return default;
        };
    }

    public static Func<Task<Unit>> AsFuncAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
        this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task> funcAsync,
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
        _ = funcAsync ?? throw new ArgumentNullException(nameof(funcAsync));

        return async () =>
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
                arg12).ConfigureAwait(AwaitOptions);

            return default;
        };
    }

    public static Func<Task<Unit>> AsFuncAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
        this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task> funcAsync,
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
        _ = funcAsync ?? throw new ArgumentNullException(nameof(funcAsync));

        return async () =>
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
                arg13).ConfigureAwait(AwaitOptions);

            return default;
        };
    }

    public static Func<Task<Unit>> AsFuncAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
        this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task> funcAsync,
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
        _ = funcAsync ?? throw new ArgumentNullException(nameof(funcAsync));

        return async () =>
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
                arg14).ConfigureAwait(AwaitOptions);

            return default;
        };
    }

    public static Func<Task<Unit>> AsFuncAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
        this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task> funcAsync,
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
        _ = funcAsync ?? throw new ArgumentNullException(nameof(funcAsync));

        return async () =>
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
                arg15).ConfigureAwait(AwaitOptions);

            return default;
        };
    }

    public static Func<Task<Unit>> AsFuncAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
        this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task> funcAsync,
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
        _ = funcAsync ?? throw new ArgumentNullException(nameof(funcAsync));

        return async () =>
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
                arg16).ConfigureAwait(AwaitOptions);

            return default;
        };
    }
}

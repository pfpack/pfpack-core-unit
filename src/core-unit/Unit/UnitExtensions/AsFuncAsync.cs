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
            await funcAsync.Invoke()
            .ConfigureAwait(AwaitOptions);

            return default;
        };
    }

    public static Func<T, Task<Unit>> AsFuncAsync<T>(
        this Func<T, Task> funcAsync)
    {
        _ = funcAsync ?? throw new ArgumentNullException(nameof(funcAsync));

        return async (arg) =>
        {
            await funcAsync.Invoke(
                arg)
            .ConfigureAwait(AwaitOptions);

            return default;
        };
    }

    public static Func<T1, T2, Task<Unit>> AsFuncAsync<T1, T2>(
        this Func<T1, T2, Task> funcAsync)
    {
        _ = funcAsync ?? throw new ArgumentNullException(nameof(funcAsync));

        return async (arg1, arg2) =>
        {
            await funcAsync.Invoke(
                arg1, arg2)
            .ConfigureAwait(AwaitOptions);

            return default;
        };
    }

    public static Func<T1, T2, T3, Task<Unit>> AsFuncAsync<T1, T2, T3>(
        this Func<T1, T2, T3, Task> funcAsync)
    {
        _ = funcAsync ?? throw new ArgumentNullException(nameof(funcAsync));

        return async (arg1, arg2, arg3) =>
        {
            await funcAsync.Invoke(
                arg1, arg2, arg3)
            .ConfigureAwait(AwaitOptions);

            return default;
        };
    }

    public static Func<T1, T2, T3, T4, Task<Unit>> AsFuncAsync<T1, T2, T3, T4>(
        this Func<T1, T2, T3, T4, Task> funcAsync)
    {
        _ = funcAsync ?? throw new ArgumentNullException(nameof(funcAsync));

        return async (arg1, arg2, arg3, arg4) =>
        {
            await funcAsync.Invoke(
                arg1, arg2, arg3, arg4)
            .ConfigureAwait(AwaitOptions);

            return default;
        };
    }

    public static Func<T1, T2, T3, T4, T5, Task<Unit>> AsFuncAsync<T1, T2, T3, T4, T5>(
        this Func<T1, T2, T3, T4, T5, Task> funcAsync)
    {
        _ = funcAsync ?? throw new ArgumentNullException(nameof(funcAsync));

        return async (arg1, arg2, arg3, arg4, arg5) =>
        {
            await funcAsync.Invoke(
                arg1, arg2, arg3, arg4, arg5)
            .ConfigureAwait(AwaitOptions);

            return default;
        };
    }

    public static Func<T1, T2, T3, T4, T5, T6, Task<Unit>> AsFuncAsync<T1, T2, T3, T4, T5, T6>(
        this Func<T1, T2, T3, T4, T5, T6, Task> funcAsync)
    {
        _ = funcAsync ?? throw new ArgumentNullException(nameof(funcAsync));

        return async (arg1, arg2, arg3, arg4, arg5, arg6) =>
        {
            await funcAsync.Invoke(
                arg1, arg2, arg3, arg4, arg5, arg6)
            .ConfigureAwait(AwaitOptions);

            return default;
        };
    }

    public static Func<T1, T2, T3, T4, T5, T6, T7, Task<Unit>> AsFuncAsync<T1, T2, T3, T4, T5, T6, T7>(
        this Func<T1, T2, T3, T4, T5, T6, T7, Task> funcAsync)
    {
        _ = funcAsync ?? throw new ArgumentNullException(nameof(funcAsync));

        return async (arg1, arg2, arg3, arg4, arg5, arg6, arg7) =>
        {
            await funcAsync.Invoke(
                arg1, arg2, arg3, arg4, arg5, arg6, arg7)
            .ConfigureAwait(AwaitOptions);

            return default;
        };
    }

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, Task<Unit>> AsFuncAsync<T1, T2, T3, T4, T5, T6, T7, T8>(
        this Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> funcAsync)
    {
        _ = funcAsync ?? throw new ArgumentNullException(nameof(funcAsync));

        return async (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) =>
        {
            await funcAsync.Invoke(
                arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8)
            .ConfigureAwait(AwaitOptions);

            return default;
        };
    }

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task<Unit>> AsFuncAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
        this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task> funcAsync)
    {
        _ = funcAsync ?? throw new ArgumentNullException(nameof(funcAsync));

        return async (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) =>
        {
            await funcAsync.Invoke(
                arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9)
            .ConfigureAwait(AwaitOptions);

            return default;
        };
    }

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task<Unit>> AsFuncAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
        this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task> funcAsync)
    {
        _ = funcAsync ?? throw new ArgumentNullException(nameof(funcAsync));

        return async (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) =>
        {
            await funcAsync.Invoke(
                arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10)
            .ConfigureAwait(AwaitOptions);

            return default;
        };
    }

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task<Unit>> AsFuncAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
        this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task> funcAsync)
    {
        _ = funcAsync ?? throw new ArgumentNullException(nameof(funcAsync));

        return async (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) =>
        {
            await funcAsync.Invoke(
                arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11)
            .ConfigureAwait(AwaitOptions);

            return default;
        };
    }

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task<Unit>> AsFuncAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
        this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task> funcAsync)
    {
        _ = funcAsync ?? throw new ArgumentNullException(nameof(funcAsync));

        return async (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) =>
        {
            await funcAsync.Invoke(
                arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12)
            .ConfigureAwait(AwaitOptions);

            return default;
        };
    }

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task<Unit>> AsFuncAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
        this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task> funcAsync)
    {
        _ = funcAsync ?? throw new ArgumentNullException(nameof(funcAsync));

        return async (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) =>
        {
            await funcAsync.Invoke(
                arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13)
            .ConfigureAwait(AwaitOptions);

            return default;
        };
    }

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task<Unit>> AsFuncAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
        this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task> funcAsync)
    {
        _ = funcAsync ?? throw new ArgumentNullException(nameof(funcAsync));

        return async (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) =>
        {
            await funcAsync.Invoke(
                arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14)
            .ConfigureAwait(AwaitOptions);

            return default;
        };
    }

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task<Unit>> AsFuncAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
        this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task> funcAsync)
    {
        _ = funcAsync ?? throw new ArgumentNullException(nameof(funcAsync));

        return async (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) =>
        {
            await funcAsync.Invoke(
                arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15)
            .ConfigureAwait(AwaitOptions);

            return default;
        };
    }

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task<Unit>> AsFuncAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
        this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task> funcAsync)
    {
        _ = funcAsync ?? throw new ArgumentNullException(nameof(funcAsync));

        return async (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) =>
        {
            await funcAsync.Invoke(
                arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16)
            .ConfigureAwait(AwaitOptions);

            return default;
        };
    }
}

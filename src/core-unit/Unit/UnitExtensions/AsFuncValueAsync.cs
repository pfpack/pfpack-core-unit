using System.Threading.Tasks;

namespace System;

partial class UnitExtensions
{
    public static Func<ValueTask<Unit>> AsFuncValueAsync(
        this Func<ValueTask> funcAsync)
    {
        _ = funcAsync ?? throw new ArgumentNullException(nameof(funcAsync));

        return async () =>
        {
            await funcAsync.Invoke()
            .ConfigureAwait(ValueAwaitOptions);

            return default;
        };
    }

    public static Func<T, ValueTask<Unit>> AsFuncValueAsync<T>(
        this Func<T, ValueTask> funcAsync)
    {
        _ = funcAsync ?? throw new ArgumentNullException(nameof(funcAsync));

        return async (arg) =>
        {
            await funcAsync.Invoke(
                arg)
            .ConfigureAwait(ValueAwaitOptions);

            return default;
        };
    }

    public static Func<T1, T2, ValueTask<Unit>> AsFuncValueAsync<T1, T2>(
        this Func<T1, T2, ValueTask> funcAsync)
    {
        _ = funcAsync ?? throw new ArgumentNullException(nameof(funcAsync));

        return async (arg1, arg2) =>
        {
            await funcAsync.Invoke(
                arg1, arg2)
            .ConfigureAwait(ValueAwaitOptions);

            return default;
        };
    }

    public static Func<T1, T2, T3, ValueTask<Unit>> AsFuncValueAsync<T1, T2, T3>(
        this Func<T1, T2, T3, ValueTask> funcAsync)
    {
        _ = funcAsync ?? throw new ArgumentNullException(nameof(funcAsync));

        return async (arg1, arg2, arg3) =>
        {
            await funcAsync.Invoke(
                arg1, arg2, arg3)
            .ConfigureAwait(ValueAwaitOptions);

            return default;
        };
    }

    public static Func<T1, T2, T3, T4, ValueTask<Unit>> AsFuncValueAsync<T1, T2, T3, T4>(
        this Func<T1, T2, T3, T4, ValueTask> funcAsync)
    {
        _ = funcAsync ?? throw new ArgumentNullException(nameof(funcAsync));

        return async (arg1, arg2, arg3, arg4) =>
        {
            await funcAsync.Invoke(
                arg1, arg2, arg3, arg4)
            .ConfigureAwait(ValueAwaitOptions);

            return default;
        };
    }

    public static Func<T1, T2, T3, T4, T5, ValueTask<Unit>> AsFuncValueAsync<T1, T2, T3, T4, T5>(
        this Func<T1, T2, T3, T4, T5, ValueTask> funcAsync)
    {
        _ = funcAsync ?? throw new ArgumentNullException(nameof(funcAsync));

        return async (arg1, arg2, arg3, arg4, arg5) =>
        {
            await funcAsync.Invoke(
                arg1, arg2, arg3, arg4, arg5)
            .ConfigureAwait(ValueAwaitOptions);

            return default;
        };
    }

    public static Func<T1, T2, T3, T4, T5, T6, ValueTask<Unit>> AsFuncValueAsync<T1, T2, T3, T4, T5, T6>(
        this Func<T1, T2, T3, T4, T5, T6, ValueTask> funcAsync)
    {
        _ = funcAsync ?? throw new ArgumentNullException(nameof(funcAsync));

        return async (arg1, arg2, arg3, arg4, arg5, arg6) =>
        {
            await funcAsync.Invoke(
                arg1, arg2, arg3, arg4, arg5, arg6)
            .ConfigureAwait(ValueAwaitOptions);

            return default;
        };
    }

    public static Func<T1, T2, T3, T4, T5, T6, T7, ValueTask<Unit>> AsFuncValueAsync<T1, T2, T3, T4, T5, T6, T7>(
        this Func<T1, T2, T3, T4, T5, T6, T7, ValueTask> funcAsync)
    {
        _ = funcAsync ?? throw new ArgumentNullException(nameof(funcAsync));

        return async (arg1, arg2, arg3, arg4, arg5, arg6, arg7) =>
        {
            await funcAsync.Invoke(
                arg1, arg2, arg3, arg4, arg5, arg6, arg7)
            .ConfigureAwait(ValueAwaitOptions);

            return default;
        };
    }

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, ValueTask<Unit>> AsFuncValueAsync<T1, T2, T3, T4, T5, T6, T7, T8>(
        this Func<T1, T2, T3, T4, T5, T6, T7, T8, ValueTask> funcAsync)
    {
        _ = funcAsync ?? throw new ArgumentNullException(nameof(funcAsync));

        return async (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) =>
        {
            await funcAsync.Invoke(
                arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8)
            .ConfigureAwait(ValueAwaitOptions);

            return default;
        };
    }

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, ValueTask<Unit>> AsFuncValueAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
        this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, ValueTask> funcAsync)
    {
        _ = funcAsync ?? throw new ArgumentNullException(nameof(funcAsync));

        return async (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) =>
        {
            await funcAsync.Invoke(
                arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9)
            .ConfigureAwait(ValueAwaitOptions);

            return default;
        };
    }

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, ValueTask<Unit>> AsFuncValueAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
        this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, ValueTask> funcAsync)
    {
        _ = funcAsync ?? throw new ArgumentNullException(nameof(funcAsync));

        return async (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) =>
        {
            await funcAsync.Invoke(
                arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10)
            .ConfigureAwait(ValueAwaitOptions);

            return default;
        };
    }

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, ValueTask<Unit>> AsFuncValueAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
        this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, ValueTask> funcAsync)
    {
        _ = funcAsync ?? throw new ArgumentNullException(nameof(funcAsync));

        return async (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) =>
        {
            await funcAsync.Invoke(
                arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11)
            .ConfigureAwait(ValueAwaitOptions);

            return default;
        };
    }

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, ValueTask<Unit>> AsFuncValueAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
        this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, ValueTask> funcAsync)
    {
        _ = funcAsync ?? throw new ArgumentNullException(nameof(funcAsync));

        return async (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) =>
        {
            await funcAsync.Invoke(
                arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12)
            .ConfigureAwait(ValueAwaitOptions);

            return default;
        };
    }

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, ValueTask<Unit>> AsFuncValueAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
        this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, ValueTask> funcAsync)
    {
        _ = funcAsync ?? throw new ArgumentNullException(nameof(funcAsync));

        return async (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) =>
        {
            await funcAsync.Invoke(
                arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13)
            .ConfigureAwait(ValueAwaitOptions);

            return default;
        };
    }

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, ValueTask<Unit>> AsFuncValueAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
        this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, ValueTask> funcAsync)
    {
        _ = funcAsync ?? throw new ArgumentNullException(nameof(funcAsync));

        return async (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) =>
        {
            await funcAsync.Invoke(
                arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14)
            .ConfigureAwait(ValueAwaitOptions);

            return default;
        };
    }

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, ValueTask<Unit>> AsFuncValueAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
        this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, ValueTask> funcAsync)
    {
        _ = funcAsync ?? throw new ArgumentNullException(nameof(funcAsync));

        return async (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) =>
        {
            await funcAsync.Invoke(
                arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15)
            .ConfigureAwait(ValueAwaitOptions);

            return default;
        };
    }

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, ValueTask<Unit>> AsFuncValueAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
        this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, ValueTask> funcAsync)
    {
        _ = funcAsync ?? throw new ArgumentNullException(nameof(funcAsync));

        return async (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) =>
        {
            await funcAsync.Invoke(
                arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16)
            .ConfigureAwait(ValueAwaitOptions);

            return default;
        };
    }
}

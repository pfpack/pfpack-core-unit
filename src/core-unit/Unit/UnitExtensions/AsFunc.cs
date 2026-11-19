namespace System;

partial class UnitExtensions
{
    public static Func<Unit> AsFunc(
        this Action action)
    {
        _ = action ?? throw new ArgumentNullException(nameof(action));

        return () =>
        {
            action.Invoke();

            return default;
        };
    }

    public static Func<Unit> AsFunc<T>(
        this Action<T> action,
        T arg)
    {
        _ = action ?? throw new ArgumentNullException(nameof(action));

        return () =>
        {
            action.Invoke(arg);

            return default;
        };
    }

    public static Func<Unit> AsFunc<T1, T2>(
        this Action<T1, T2> action,
        T1 arg1,
        T2 arg2)
    {
        _ = action ?? throw new ArgumentNullException(nameof(action));

        return () =>
        {
            action.Invoke(
                arg1,
                arg2);

            return default;
        };
    }

    public static Func<Unit> AsFunc<T1, T2, T3>(
        this Action<T1, T2, T3> action,
        T1 arg1,
        T2 arg2,
        T3 arg3)
    {
        _ = action ?? throw new ArgumentNullException(nameof(action));

        return () =>
        {
            action.Invoke(
                arg1,
                arg2,
                arg3);

            return default;
        };
    }

    public static Func<Unit> AsFunc<T1, T2, T3, T4>(
        this Action<T1, T2, T3, T4> action,
        T1 arg1,
        T2 arg2,
        T3 arg3,
        T4 arg4)
    {
        _ = action ?? throw new ArgumentNullException(nameof(action));

        return () =>
        {
            action.Invoke(
                arg1,
                arg2,
                arg3,
                arg4);

            return default;
        };
    }

    public static Func<Unit> AsFunc<T1, T2, T3, T4, T5>(
        this Action<T1, T2, T3, T4, T5> action,
        T1 arg1,
        T2 arg2,
        T3 arg3,
        T4 arg4,
        T5 arg5)
    {
        _ = action ?? throw new ArgumentNullException(nameof(action));

        return () =>
        {
            action.Invoke(
                arg1,
                arg2,
                arg3,
                arg4,
                arg5);

            return default;
        };
    }

    public static Func<Unit> AsFunc<T1, T2, T3, T4, T5, T6>(
        this Action<T1, T2, T3, T4, T5, T6> action,
        T1 arg1,
        T2 arg2,
        T3 arg3,
        T4 arg4,
        T5 arg5,
        T6 arg6)
    {
        _ = action ?? throw new ArgumentNullException(nameof(action));

        return () =>
        {
            action.Invoke(
                arg1,
                arg2,
                arg3,
                arg4,
                arg5,
                arg6);

            return default;
        };
    }

    public static Func<Unit> AsFunc<T1, T2, T3, T4, T5, T6, T7>(
        this Action<T1, T2, T3, T4, T5, T6, T7> action,
        T1 arg1,
        T2 arg2,
        T3 arg3,
        T4 arg4,
        T5 arg5,
        T6 arg6,
        T7 arg7)
    {
        _ = action ?? throw new ArgumentNullException(nameof(action));

        return () =>
        {
            action.Invoke(
                arg1,
                arg2,
                arg3,
                arg4,
                arg5,
                arg6,
                arg7);

            return default;
        };
    }

    public static Func<Unit> AsFunc<T1, T2, T3, T4, T5, T6, T7, T8>(
        this Action<T1, T2, T3, T4, T5, T6, T7, T8> action,
        T1 arg1,
        T2 arg2,
        T3 arg3,
        T4 arg4,
        T5 arg5,
        T6 arg6,
        T7 arg7,
        T8 arg8)
    {
        _ = action ?? throw new ArgumentNullException(nameof(action));

        return () =>
        {
            action.Invoke(
                arg1,
                arg2,
                arg3,
                arg4,
                arg5,
                arg6,
                arg7,
                arg8);

            return default;
        };
    }

    public static Func<Unit> AsFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
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
    {
        _ = action ?? throw new ArgumentNullException(nameof(action));

        return () =>
        {
            action.Invoke(
                arg1,
                arg2,
                arg3,
                arg4,
                arg5,
                arg6,
                arg7,
                arg8,
                arg9);

            return default;
        };
    }

    public static Func<Unit> AsFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
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
    {
        _ = action ?? throw new ArgumentNullException(nameof(action));

        return () =>
        {
            action.Invoke(
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

            return default;
        };
    }

    public static Func<Unit> AsFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
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
    {
        _ = action ?? throw new ArgumentNullException(nameof(action));

        return () =>
        {
            action.Invoke(
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

            return default;
        };
    }

    public static Func<Unit> AsFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
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
    {
        _ = action ?? throw new ArgumentNullException(nameof(action));

        return () =>
        {
            action.Invoke(
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

            return default;
        };
    }

    public static Func<Unit> AsFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
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
    {
        _ = action ?? throw new ArgumentNullException(nameof(action));

        return () =>
        {
            action.Invoke(
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

            return default;
        };
    }

    public static Func<Unit> AsFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
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
    {
        _ = action ?? throw new ArgumentNullException(nameof(action));

        return () =>
        {
            action.Invoke(
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

            return default;
        };
    }

    public static Func<Unit> AsFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
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
    {
        _ = action ?? throw new ArgumentNullException(nameof(action));

        return () =>
        {
            action.Invoke(
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

            return default;
        };
    }

    public static Func<Unit> AsFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
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
    {
        _ = action ?? throw new ArgumentNullException(nameof(action));

        return () =>
        {
            action.Invoke(
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

            return default;
        };
    }
}

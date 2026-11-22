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

    public static Func<T, Unit> AsFunc<T>(
        this Action<T> action)
        where T : allows ref struct
    {
        _ = action ?? throw new ArgumentNullException(nameof(action));

        return (arg) =>
        {
            action.Invoke(
                arg);

            return default;
        };
    }

    public static Func<T1, T2, Unit> AsFunc<T1, T2>(
        this Action<T1, T2> action)
        where T1 : allows ref struct
        where T2 : allows ref struct
    {
        _ = action ?? throw new ArgumentNullException(nameof(action));

        return (arg1, arg2) =>
        {
            action.Invoke(
                arg1, arg2);

            return default;
        };
    }

    public static Func<T1, T2, T3, Unit> AsFunc<T1, T2, T3>(
        this Action<T1, T2, T3> action)
        where T1 : allows ref struct
        where T2 : allows ref struct
        where T3 : allows ref struct
    {
        _ = action ?? throw new ArgumentNullException(nameof(action));

        return (arg1, arg2, arg3) =>
        {
            action.Invoke(
                arg1, arg2, arg3);

            return default;
        };
    }

    public static Func<T1, T2, T3, T4, Unit> AsFunc<T1, T2, T3, T4>(
        this Action<T1, T2, T3, T4> action)
        where T1 : allows ref struct
        where T2 : allows ref struct
        where T3 : allows ref struct
        where T4 : allows ref struct
    {
        _ = action ?? throw new ArgumentNullException(nameof(action));

        return (arg1, arg2, arg3, arg4) =>
        {
            action.Invoke(
                arg1, arg2, arg3, arg4);

            return default;
        };
    }

    public static Func<T1, T2, T3, T4, T5, Unit> AsFunc<T1, T2, T3, T4, T5>(
        this Action<T1, T2, T3, T4, T5> action)
        where T1 : allows ref struct
        where T2 : allows ref struct
        where T3 : allows ref struct
        where T4 : allows ref struct
        where T5 : allows ref struct
    {
        _ = action ?? throw new ArgumentNullException(nameof(action));

        return (arg1, arg2, arg3, arg4, arg5) =>
        {
            action.Invoke(
                arg1, arg2, arg3, arg4, arg5);

            return default;
        };
    }

    public static Func<T1, T2, T3, T4, T5, T6, Unit> AsFunc<T1, T2, T3, T4, T5, T6>(
        this Action<T1, T2, T3, T4, T5, T6> action)
        where T1 : allows ref struct
        where T2 : allows ref struct
        where T3 : allows ref struct
        where T4 : allows ref struct
        where T5 : allows ref struct
        where T6 : allows ref struct
    {
        _ = action ?? throw new ArgumentNullException(nameof(action));

        return (arg1, arg2, arg3, arg4, arg5, arg6) =>
        {
            action.Invoke(
                arg1, arg2, arg3, arg4, arg5, arg6);

            return default;
        };
    }

    public static Func<T1, T2, T3, T4, T5, T6, T7, Unit> AsFunc<T1, T2, T3, T4, T5, T6, T7>(
        this Action<T1, T2, T3, T4, T5, T6, T7> action)
        where T1 : allows ref struct
        where T2 : allows ref struct
        where T3 : allows ref struct
        where T4 : allows ref struct
        where T5 : allows ref struct
        where T6 : allows ref struct
        where T7 : allows ref struct
    {
        _ = action ?? throw new ArgumentNullException(nameof(action));

        return (arg1, arg2, arg3, arg4, arg5, arg6, arg7) =>
        {
            action.Invoke(
                arg1, arg2, arg3, arg4, arg5, arg6, arg7);

            return default;
        };
    }

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, Unit> AsFunc<T1, T2, T3, T4, T5, T6, T7, T8>(
        this Action<T1, T2, T3, T4, T5, T6, T7, T8> action)
        where T1 : allows ref struct
        where T2 : allows ref struct
        where T3 : allows ref struct
        where T4 : allows ref struct
        where T5 : allows ref struct
        where T6 : allows ref struct
        where T7 : allows ref struct
        where T8 : allows ref struct
    {
        _ = action ?? throw new ArgumentNullException(nameof(action));

        return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) =>
        {
            action.Invoke(
                arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

            return default;
        };
    }

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Unit> AsFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
        this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action)
        where T1 : allows ref struct
        where T2 : allows ref struct
        where T3 : allows ref struct
        where T4 : allows ref struct
        where T5 : allows ref struct
        where T6 : allows ref struct
        where T7 : allows ref struct
        where T8 : allows ref struct
        where T9 : allows ref struct
    {
        _ = action ?? throw new ArgumentNullException(nameof(action));

        return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) =>
        {
            action.Invoke(
                arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);

            return default;
        };
    }

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Unit> AsFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
        this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action)
        where T1 : allows ref struct
        where T2 : allows ref struct
        where T3 : allows ref struct
        where T4 : allows ref struct
        where T5 : allows ref struct
        where T6 : allows ref struct
        where T7 : allows ref struct
        where T8 : allows ref struct
        where T9 : allows ref struct
        where T10 : allows ref struct
    {
        _ = action ?? throw new ArgumentNullException(nameof(action));

        return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) =>
        {
            action.Invoke(
                arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);

            return default;
        };
    }

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Unit> AsFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
        this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action)
        where T1 : allows ref struct
        where T2 : allows ref struct
        where T3 : allows ref struct
        where T4 : allows ref struct
        where T5 : allows ref struct
        where T6 : allows ref struct
        where T7 : allows ref struct
        where T8 : allows ref struct
        where T9 : allows ref struct
        where T10 : allows ref struct
        where T11 : allows ref struct
    {
        _ = action ?? throw new ArgumentNullException(nameof(action));

        return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) =>
        {
            action.Invoke(
                arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);

            return default;
        };
    }

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Unit> AsFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
        this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action)
        where T1 : allows ref struct
        where T2 : allows ref struct
        where T3 : allows ref struct
        where T4 : allows ref struct
        where T5 : allows ref struct
        where T6 : allows ref struct
        where T7 : allows ref struct
        where T8 : allows ref struct
        where T9 : allows ref struct
        where T10 : allows ref struct
        where T11 : allows ref struct
        where T12 : allows ref struct
    {
        _ = action ?? throw new ArgumentNullException(nameof(action));

        return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) =>
        {
            action.Invoke(
                arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);

            return default;
        };
    }

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Unit> AsFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
        this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action)
        where T1 : allows ref struct
        where T2 : allows ref struct
        where T3 : allows ref struct
        where T4 : allows ref struct
        where T5 : allows ref struct
        where T6 : allows ref struct
        where T7 : allows ref struct
        where T8 : allows ref struct
        where T9 : allows ref struct
        where T10 : allows ref struct
        where T11 : allows ref struct
        where T12 : allows ref struct
        where T13 : allows ref struct
    {
        _ = action ?? throw new ArgumentNullException(nameof(action));

        return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) =>
        {
            action.Invoke(
                arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);

            return default;
        };
    }

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Unit> AsFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
        this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action)
        where T1 : allows ref struct
        where T2 : allows ref struct
        where T3 : allows ref struct
        where T4 : allows ref struct
        where T5 : allows ref struct
        where T6 : allows ref struct
        where T7 : allows ref struct
        where T8 : allows ref struct
        where T9 : allows ref struct
        where T10 : allows ref struct
        where T11 : allows ref struct
        where T12 : allows ref struct
        where T13 : allows ref struct
        where T14 : allows ref struct
    {
        _ = action ?? throw new ArgumentNullException(nameof(action));

        return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) =>
        {
            action.Invoke(
                arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);

            return default;
        };
    }

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Unit> AsFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
        this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action)
        where T1 : allows ref struct
        where T2 : allows ref struct
        where T3 : allows ref struct
        where T4 : allows ref struct
        where T5 : allows ref struct
        where T6 : allows ref struct
        where T7 : allows ref struct
        where T8 : allows ref struct
        where T9 : allows ref struct
        where T10 : allows ref struct
        where T11 : allows ref struct
        where T12 : allows ref struct
        where T13 : allows ref struct
        where T14 : allows ref struct
        where T15 : allows ref struct
    {
        _ = action ?? throw new ArgumentNullException(nameof(action));

        return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) =>
        {
            action.Invoke(
                arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);

            return default;
        };
    }

    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Unit> AsFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
        this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action)
        where T1 : allows ref struct
        where T2 : allows ref struct
        where T3 : allows ref struct
        where T4 : allows ref struct
        where T5 : allows ref struct
        where T6 : allows ref struct
        where T7 : allows ref struct
        where T8 : allows ref struct
        where T9 : allows ref struct
        where T10 : allows ref struct
        where T11 : allows ref struct
        where T12 : allows ref struct
        where T13 : allows ref struct
        where T14 : allows ref struct
        where T15 : allows ref struct
        where T16 : allows ref struct
    {
        _ = action ?? throw new ArgumentNullException(nameof(action));

        return (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) =>
        {
            action.Invoke(
                arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);

            return default;
        };
    }
}

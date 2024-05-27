using Moq;

namespace PrimeFuncPack.Core.Tests;

internal static class MockFuncFactory
{
    public static Mock<IFunc<TResult>> CreateMockFunc<TResult>(TResult result)
    {
        Mock<IFunc<TResult>> mock = new(MockBehavior.Strict);
        mock.Setup(func => func.Invoke()).Returns(result);
        return mock;
    }

    public static Mock<IFunc<TSource, TResult>> CreateMockFunc<TSource, TResult>(TResult result)
    {
        Mock<IFunc<TSource, TResult>> mock = new(MockBehavior.Strict);
        mock.Setup(func => func.Invoke(It.IsAny<TSource>())).Returns(result);
        return mock;
    }

    public static Mock<IFunc<T1, T2, TResult>> CreateMockFunc<T1, T2, TResult>(TResult result)
    {
        Mock<IFunc<T1, T2, TResult>> mock = new(MockBehavior.Strict);
        mock.Setup(func => func.Invoke(It.IsAny<T1>(), It.IsAny<T2>())).Returns(result);
        return mock;
    }

    public static Mock<IFunc<T1, T2, T3, TResult>> CreateMockFunc<T1, T2, T3, TResult>(TResult result)
    {
        Mock<IFunc<T1, T2, T3, TResult>> mock = new(MockBehavior.Strict);
        mock.Setup(func => func.Invoke(It.IsAny<T1>(), It.IsAny<T2>(), It.IsAny<T3>())).Returns(result);
        return mock;
    }

    public static Mock<IFunc<T1, T2, T3, T4, TResult>> CreateMockFunc<T1, T2, T3, T4, TResult>(TResult result)
    {
        Mock<IFunc<T1, T2, T3, T4, TResult>> mock = new(MockBehavior.Strict);
        mock.Setup(func => func.Invoke(It.IsAny<T1>(), It.IsAny<T2>(), It.IsAny<T3>(), It.IsAny<T4>())).Returns(result);
        return mock;
    }

    public static Mock<IFunc<T1, T2, T3, T4, T5, TResult>> CreateMockFunc<T1, T2, T3, T4, T5, TResult>(TResult result)
    {
        Mock<IFunc<T1, T2, T3, T4, T5, TResult>> mock = new(MockBehavior.Strict);
        mock.Setup(func => func.Invoke(It.IsAny<T1>(), It.IsAny<T2>(), It.IsAny<T3>(), It.IsAny<T4>(), It.IsAny<T5>())).Returns(result);
        return mock;
    }

    public static Mock<IFunc<T1, T2, T3, T4, T5, T6, TResult>> CreateMockFunc<T1, T2, T3, T4, T5, T6, TResult>(TResult result)
    {
        Mock<IFunc<T1, T2, T3, T4, T5, T6, TResult>> mock = new(MockBehavior.Strict);
        mock.Setup(func => func.Invoke(It.IsAny<T1>(), It.IsAny<T2>(), It.IsAny<T3>(), It.IsAny<T4>(), It.IsAny<T5>(), It.IsAny<T6>())).Returns(result);
        return mock;
    }

    public static Mock<IFunc<T1, T2, T3, T4, T5, T6, T7, TResult>> CreateMockFunc<T1, T2, T3, T4, T5, T6, T7, TResult>(TResult result)
    {
        Mock<IFunc<T1, T2, T3, T4, T5, T6, T7, TResult>> mock = new(MockBehavior.Strict);
        mock.Setup(func => func.Invoke(It.IsAny<T1>(), It.IsAny<T2>(), It.IsAny<T3>(), It.IsAny<T4>(), It.IsAny<T5>(), It.IsAny<T6>(), It.IsAny<T7>())).Returns(result);
        return mock;
    }

    public static Mock<IFunc<T1, T2, T3, T4, T5, T6, T7, T8, TResult>> CreateMockFunc<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(TResult result)
    {
        Mock<IFunc<T1, T2, T3, T4, T5, T6, T7, T8, TResult>> mock = new(MockBehavior.Strict);
        mock.Setup(func => func.Invoke(It.IsAny<T1>(), It.IsAny<T2>(), It.IsAny<T3>(), It.IsAny<T4>(), It.IsAny<T5>(), It.IsAny<T6>(), It.IsAny<T7>(), It.IsAny<T8>())).Returns(result);
        return mock;
    }

    public static Mock<IFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>> CreateMockFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(TResult result)
    {
        Mock<IFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>> mock = new(MockBehavior.Strict);
        mock.Setup(func => func.Invoke(It.IsAny<T1>(), It.IsAny<T2>(), It.IsAny<T3>(), It.IsAny<T4>(), It.IsAny<T5>(), It.IsAny<T6>(), It.IsAny<T7>(), It.IsAny<T8>(), It.IsAny<T9>())).Returns(result);
        return mock;
    }

    public static Mock<IFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>> CreateMockFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(TResult result)
    {
        Mock<IFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>> mock = new(MockBehavior.Strict);
        mock.Setup(func => func.Invoke(It.IsAny<T1>(), It.IsAny<T2>(), It.IsAny<T3>(), It.IsAny<T4>(), It.IsAny<T5>(), It.IsAny<T6>(), It.IsAny<T7>(), It.IsAny<T8>(), It.IsAny<T9>(), It.IsAny<T10>())).Returns(result);
        return mock;
    }

    public static Mock<IFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>> CreateMockFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(TResult result)
    {
        Mock<IFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>> mock = new(MockBehavior.Strict);
        mock.Setup(func => func.Invoke(It.IsAny<T1>(), It.IsAny<T2>(), It.IsAny<T3>(), It.IsAny<T4>(), It.IsAny<T5>(), It.IsAny<T6>(), It.IsAny<T7>(), It.IsAny<T8>(), It.IsAny<T9>(), It.IsAny<T10>(), It.IsAny<T11>())).Returns(result);
        return mock;
    }

    public static Mock<IFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>> CreateMockFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(TResult result)
    {
        Mock<IFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>> mock = new(MockBehavior.Strict);
        mock.Setup(func => func.Invoke(It.IsAny<T1>(), It.IsAny<T2>(), It.IsAny<T3>(), It.IsAny<T4>(), It.IsAny<T5>(), It.IsAny<T6>(), It.IsAny<T7>(), It.IsAny<T8>(), It.IsAny<T9>(), It.IsAny<T10>(), It.IsAny<T11>(), It.IsAny<T12>())).Returns(result);
        return mock;
    }

    public static Mock<IFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> CreateMockFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(TResult result)
    {
        Mock<IFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>> mock = new(MockBehavior.Strict);
        mock.Setup(func => func.Invoke(It.IsAny<T1>(), It.IsAny<T2>(), It.IsAny<T3>(), It.IsAny<T4>(), It.IsAny<T5>(), It.IsAny<T6>(), It.IsAny<T7>(), It.IsAny<T8>(), It.IsAny<T9>(), It.IsAny<T10>(), It.IsAny<T11>(), It.IsAny<T12>(), It.IsAny<T13>())).Returns(result);
        return mock;
    }

    public static Mock<IFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> CreateMockFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(TResult result)
    {
        Mock<IFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>> mock = new(MockBehavior.Strict);
        mock.Setup(func => func.Invoke(It.IsAny<T1>(), It.IsAny<T2>(), It.IsAny<T3>(), It.IsAny<T4>(), It.IsAny<T5>(), It.IsAny<T6>(), It.IsAny<T7>(), It.IsAny<T8>(), It.IsAny<T9>(), It.IsAny<T10>(), It.IsAny<T11>(), It.IsAny<T12>(), It.IsAny<T13>(), It.IsAny<T14>())).Returns(result);
        return mock;
    }

    public static Mock<IFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> CreateMockFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(TResult result)
    {
        Mock<IFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>> mock = new(MockBehavior.Strict);
        mock.Setup(func => func.Invoke(It.IsAny<T1>(), It.IsAny<T2>(), It.IsAny<T3>(), It.IsAny<T4>(), It.IsAny<T5>(), It.IsAny<T6>(), It.IsAny<T7>(), It.IsAny<T8>(), It.IsAny<T9>(), It.IsAny<T10>(), It.IsAny<T11>(), It.IsAny<T12>(), It.IsAny<T13>(), It.IsAny<T14>(), It.IsAny<T15>())).Returns(result);
        return mock;
    }

    public static Mock<IFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> CreateMockFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(TResult result)
    {
        Mock<IFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>> mock = new(MockBehavior.Strict);
        mock.Setup(func => func.Invoke(It.IsAny<T1>(), It.IsAny<T2>(), It.IsAny<T3>(), It.IsAny<T4>(), It.IsAny<T5>(), It.IsAny<T6>(), It.IsAny<T7>(), It.IsAny<T8>(), It.IsAny<T9>(), It.IsAny<T10>(), It.IsAny<T11>(), It.IsAny<T12>(), It.IsAny<T13>(), It.IsAny<T14>(), It.IsAny<T15>(), It.IsAny<T16>())).Returns(result);
        return mock;
    }
}

using Moq;

namespace PrimeFuncPack.Core.Tests;

internal static class MockActionFactory
{
    public static Mock<IAction> CreateMockAction()
    {
        Mock<IAction> mock = new(MockBehavior.Strict);
        mock.Setup(action => action.Invoke());
        return mock;
    }

    public static Mock<IAction<TSource>> CreateMockAction<TSource>()
    {
        Mock<IAction<TSource>> mock = new(MockBehavior.Strict);
        mock.Setup(action => action.Invoke(It.IsAny<TSource>()));
        return mock;
    }

    public static Mock<IAction<T1, T2>> CreateMockAction<T1, T2>()
    {
        Mock<IAction<T1, T2>> mock = new(MockBehavior.Strict);
        mock.Setup(action => action.Invoke(It.IsAny<T1>(), It.IsAny<T2>()));
        return mock;
    }

    public static Mock<IAction<T1, T2, T3>> CreateMockAction<T1, T2, T3>()
    {
        Mock<IAction<T1, T2, T3>> mock = new(MockBehavior.Strict);
        mock.Setup(action => action.Invoke(It.IsAny<T1>(), It.IsAny<T2>(), It.IsAny<T3>()));
        return mock;
    }

    public static Mock<IAction<T1, T2, T3, T4>> CreateMockAction<T1, T2, T3, T4>()
    {
        Mock<IAction<T1, T2, T3, T4>> mock = new(MockBehavior.Strict);
        mock.Setup(action => action.Invoke(It.IsAny<T1>(), It.IsAny<T2>(), It.IsAny<T3>(), It.IsAny<T4>()));
        return mock;
    }

    public static Mock<IAction<T1, T2, T3, T4, T5>> CreateMockAction<T1, T2, T3, T4, T5>()
    {
        Mock<IAction<T1, T2, T3, T4, T5>> mock = new(MockBehavior.Strict);
        mock.Setup(action => action.Invoke(It.IsAny<T1>(), It.IsAny<T2>(), It.IsAny<T3>(), It.IsAny<T4>(), It.IsAny<T5>()));
        return mock;
    }

    public static Mock<IAction<T1, T2, T3, T4, T5, T6>> CreateMockAction<T1, T2, T3, T4, T5, T6>()
    {
        Mock<IAction<T1, T2, T3, T4, T5, T6>> mock = new(MockBehavior.Strict);
        mock.Setup(action => action.Invoke(It.IsAny<T1>(), It.IsAny<T2>(), It.IsAny<T3>(), It.IsAny<T4>(), It.IsAny<T5>(), It.IsAny<T6>()));
        return mock;
    }

    public static Mock<IAction<T1, T2, T3, T4, T5, T6, T7>> CreateMockAction<T1, T2, T3, T4, T5, T6, T7>()
    {
        Mock<IAction<T1, T2, T3, T4, T5, T6, T7>> mock = new(MockBehavior.Strict);
        mock.Setup(action => action.Invoke(It.IsAny<T1>(), It.IsAny<T2>(), It.IsAny<T3>(), It.IsAny<T4>(), It.IsAny<T5>(), It.IsAny<T6>(), It.IsAny<T7>()));
        return mock;
    }

    public static Mock<IAction<T1, T2, T3, T4, T5, T6, T7, T8>> CreateMockAction<T1, T2, T3, T4, T5, T6, T7, T8>()
    {
        Mock<IAction<T1, T2, T3, T4, T5, T6, T7, T8>> mock = new(MockBehavior.Strict);
        mock.Setup(action => action.Invoke(It.IsAny<T1>(), It.IsAny<T2>(), It.IsAny<T3>(), It.IsAny<T4>(), It.IsAny<T5>(), It.IsAny<T6>(), It.IsAny<T7>(), It.IsAny<T8>()));
        return mock;
    }

    public static Mock<IAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>> CreateMockAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>()
    {
        Mock<IAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>> mock = new(MockBehavior.Strict);
        mock.Setup(action => action.Invoke(It.IsAny<T1>(), It.IsAny<T2>(), It.IsAny<T3>(), It.IsAny<T4>(), It.IsAny<T5>(), It.IsAny<T6>(), It.IsAny<T7>(), It.IsAny<T8>(), It.IsAny<T9>()));
        return mock;
    }

    public static Mock<IAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> CreateMockAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>()
    {
        Mock<IAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> mock = new(MockBehavior.Strict);
        mock.Setup(action => action.Invoke(It.IsAny<T1>(), It.IsAny<T2>(), It.IsAny<T3>(), It.IsAny<T4>(), It.IsAny<T5>(), It.IsAny<T6>(), It.IsAny<T7>(), It.IsAny<T8>(), It.IsAny<T9>(), It.IsAny<T10>()));
        return mock;
    }

    public static Mock<IAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> CreateMockAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>()
    {
        Mock<IAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> mock = new(MockBehavior.Strict);
        mock.Setup(action => action.Invoke(It.IsAny<T1>(), It.IsAny<T2>(), It.IsAny<T3>(), It.IsAny<T4>(), It.IsAny<T5>(), It.IsAny<T6>(), It.IsAny<T7>(), It.IsAny<T8>(), It.IsAny<T9>(), It.IsAny<T10>(), It.IsAny<T11>()));
        return mock;
    }

    public static Mock<IAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> CreateMockAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>()
    {
        Mock<IAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> mock = new(MockBehavior.Strict);
        mock.Setup(action => action.Invoke(It.IsAny<T1>(), It.IsAny<T2>(), It.IsAny<T3>(), It.IsAny<T4>(), It.IsAny<T5>(), It.IsAny<T6>(), It.IsAny<T7>(), It.IsAny<T8>(), It.IsAny<T9>(), It.IsAny<T10>(), It.IsAny<T11>(), It.IsAny<T12>()));
        return mock;
    }

    public static Mock<IAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> CreateMockAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>()
    {
        Mock<IAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> mock = new(MockBehavior.Strict);
        mock.Setup(action => action.Invoke(It.IsAny<T1>(), It.IsAny<T2>(), It.IsAny<T3>(), It.IsAny<T4>(), It.IsAny<T5>(), It.IsAny<T6>(), It.IsAny<T7>(), It.IsAny<T8>(), It.IsAny<T9>(), It.IsAny<T10>(), It.IsAny<T11>(), It.IsAny<T12>(), It.IsAny<T13>()));
        return mock;
    }

    public static Mock<IAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> CreateMockAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>()
    {
        Mock<IAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> mock = new(MockBehavior.Strict);
        mock.Setup(action => action.Invoke(It.IsAny<T1>(), It.IsAny<T2>(), It.IsAny<T3>(), It.IsAny<T4>(), It.IsAny<T5>(), It.IsAny<T6>(), It.IsAny<T7>(), It.IsAny<T8>(), It.IsAny<T9>(), It.IsAny<T10>(), It.IsAny<T11>(), It.IsAny<T12>(), It.IsAny<T13>(), It.IsAny<T14>()));
        return mock;
    }

    public static Mock<IAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> CreateMockAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>()
    {
        Mock<IAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> mock = new(MockBehavior.Strict);
        mock.Setup(action => action.Invoke(It.IsAny<T1>(), It.IsAny<T2>(), It.IsAny<T3>(), It.IsAny<T4>(), It.IsAny<T5>(), It.IsAny<T6>(), It.IsAny<T7>(), It.IsAny<T8>(), It.IsAny<T9>(), It.IsAny<T10>(), It.IsAny<T11>(), It.IsAny<T12>(), It.IsAny<T13>(), It.IsAny<T14>(), It.IsAny<T15>()));
        return mock;
    }

    public static Mock<IAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> CreateMockAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>()
    {
        Mock<IAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> mock = new(MockBehavior.Strict);
        mock.Setup(action => action.Invoke(It.IsAny<T1>(), It.IsAny<T2>(), It.IsAny<T3>(), It.IsAny<T4>(), It.IsAny<T5>(), It.IsAny<T6>(), It.IsAny<T7>(), It.IsAny<T8>(), It.IsAny<T9>(), It.IsAny<T10>(), It.IsAny<T11>(), It.IsAny<T12>(), It.IsAny<T13>(), It.IsAny<T14>(), It.IsAny<T15>(), It.IsAny<T16>()));
        return mock;
    }
}

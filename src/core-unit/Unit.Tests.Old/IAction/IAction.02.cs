namespace PrimeFuncPack.Core.Tests;

public interface IAction<in T1, in T2>
{
    void Invoke(T1 arg1, T2 arg2);
}

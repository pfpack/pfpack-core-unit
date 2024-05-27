namespace PrimeFuncPack.Core.Tests;

public interface IAction<in T>
{
    void Invoke(T arg);
}

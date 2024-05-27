namespace PrimeFuncPack.Core.Tests;

public interface IFunc<in T, out TResult>
{
    TResult Invoke(T arg);
}

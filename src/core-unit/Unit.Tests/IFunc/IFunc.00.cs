namespace PrimeFuncPack.Core.Tests;

public interface IFunc<out TResult>
{
    TResult Invoke();
}

#nullable enable

using System.Threading;
using System.Threading.Tasks;

namespace System
{
    partial class Func
    {
        public static IAsyncFunc<T1, T2, TResult> Create<T1, T2, TResult>(
            Func<T1, T2, CancellationToken, ValueTask<TResult>> func)
            =>
            new ImplAsyncFunc<T1, T2, TResult>(
                func ?? throw new ArgumentNullException(nameof(func)));
    }
}
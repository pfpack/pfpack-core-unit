﻿#nullable enable

namespace System
{
    partial class InternalTaggedUnionExtensions
    {
        internal static Result<TSuccess, TFailure> AsResult<TSuccess, TFailure>(this in TaggedUnion<TSuccess, TFailure> union)
            where TSuccess : notnull
            where TFailure : notnull, new()
            =>
            Result<TSuccess, TFailure>.Wrap(union);
    }
}

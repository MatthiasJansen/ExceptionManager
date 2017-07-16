#region headers

// Copyright (c) 2017 Matthias Jansen
// See the LICENSE file in the project root for more information.

#endregion

#region imports

using System;

#endregion

namespace Exceptional.Plugable.Resolver
{
    public class DefaultResolver : IExceptionalResolver
    {
        public T Resolve<T>()
        {
            return Activator.CreateInstance<T>();
        }

        public object Resolve(Type type)
        {
            return Activator.CreateInstance(type);
        }
    }
}
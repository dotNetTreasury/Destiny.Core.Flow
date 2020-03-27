﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Destiny.Core.Flow.Dependency;

namespace Destiny.Core.Flow.Reflection
{

    public class TypeFinder : FinderBase<Type>, ITypeFinder
    {

        private readonly IAssemblyFinder _assemblyFinder = null;
        private readonly object _syncObj = new object();
        public TypeFinder(IAssemblyFinder assemblyFinder)
        {
            _assemblyFinder = assemblyFinder;
        }

        protected override Type[] FindAllItems()
        {
          return  _assemblyFinder.FindAll().SelectMany(o=>o.GetTypes()).ToArray();
        }
    }
}

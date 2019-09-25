using System;
using System.Collections.Generic;
using System.Text;

namespace TDD.Demo.NUnitTests.Class
{
    internal class Dependent
    {
        private readonly IDependency _dependency;
        public Dependent(IDependency dependency)
        {
            _dependency = dependency;
        }
        public int GetValue(string s)
        {
            return _dependency.GetValue(s);
        }
    }
    internal interface IDependency
    {
        int GetValue(string param);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySampleWebApp
{
    public class Calculator
    {
        public const string defaultPwd = "SomeString";
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Subtract(int a, int b)
        {
            return b - a;
        }
    }
}
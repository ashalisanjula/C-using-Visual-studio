using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_concepts
{
    static class Calculator
    {
        static int count = 0;
        static Calculator()
        {
            count = 0;
        }

        public static int increment() { count++; return count; }
        public static int decrement() { count--; return count; }
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_concepts
{
    static class intExtensions
    {
        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;   
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_concepts
{
    internal class Calculation
    {
        public void calculate(int num1, int num2) {
            try
            {
                int result = num1 / num2;
                Console.WriteLine(result);
            }
            catch(Exception e) 
            {
                Console.WriteLine(e.Message);
           
            }
        }
    }
}

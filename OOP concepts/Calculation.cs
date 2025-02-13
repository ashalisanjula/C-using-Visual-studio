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
            int result = 0;
            try
            {
                 result = num1 / num2;
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            finally 
            {
                Console.WriteLine("I will always execute");
                Console.WriteLine(result);
            }
        }

        public void calculateAnother()
        {
            int num1,num2,result = 0;
            try
            {
                Console.Write("Enter Number one: ");
                num1 = int.Parse(Console.ReadLine());

                Console.Write("Enter Number two: ");
                num2 = int.Parse(Console.ReadLine());

                result = num1 / num2;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            finally
            {
                Console.WriteLine("I will always execute");
                Console.WriteLine(result);
            }
        }
    }
}

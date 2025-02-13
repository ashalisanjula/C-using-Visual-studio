using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Declaring a Delegate
delegate int CalculateDelegate(int num);

namespace Anonymous_type_Delegates__Events_and_Lambda
{

    internal class DelegateExamples
    {
        static int number = 100;
        public static int addition(int num)
        {
            number = number + num;
            return number;
        }

        public static int Multiplication(int num) 
        {
            number = number * num;
            return number;
        }

        public static int getNumber() 
        { 
            return number;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_type_Delegates__Events_and_Lambda
{
    //publisher model

    internal class EventsExamples
    {

        //declare delegate
        public delegate void delegate_OddNumber();

        //declare event
        public event delegate_OddNumber event_OddNumber;


        public void addition()
        {
            int num1 = 165; int num2 = 200;
            int result = num1 + num2;
            Console.WriteLine(result);
            if (result % 2 != 0 && event_OddNumber != null)
            {
                //Raise event
                event_OddNumber();
            }
        }
    }
}

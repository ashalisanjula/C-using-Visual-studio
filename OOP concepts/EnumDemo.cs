using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_concepts
{
    enum WeekDays
    {
        Monday, 
        Tuesday, 
        Wednesday, 
        Thursday,
        Friday,
        Saturday, 
        Sunday
    }

    internal class EnumDemo
    {
        public void display()
        {
            Console.WriteLine(WeekDays.Monday);
            int day =(int)WeekDays.Monday;
            Console.WriteLine(WeekDays.Monday+ ":" +day);

            Console.WriteLine(WeekDays.Tuesday);
             day = (int)WeekDays.Tuesday;
            Console.WriteLine(WeekDays.Tuesday + ":" + day);

            Console.WriteLine(WeekDays.Wednesday);
             day = (int)WeekDays.Wednesday;
            Console.WriteLine(WeekDays.Wednesday + ":" + day);
        }
    }
}

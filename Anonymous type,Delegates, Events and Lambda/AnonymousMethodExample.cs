using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_type_Delegates__Events_and_Lambda
{
    public delegate void PrintMessage(string message);
    internal class AnonymousMethodExample
    {
        public static void InvokeMethod()
        {
            PrintMessage printMessage = delegate (string message)
            {
                Console.WriteLine("Message: "+message);
            };
            printMessage("Hello World");
        }
    }
}

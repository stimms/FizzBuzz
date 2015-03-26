using System;
using System.Linq;
using System.Collections.Generic;

namespace FizzBuzz
{
    public class ConsolePrinter : IPrinter
    {

        public void Print(string toPrint)
        {

            Console.Write(toPrint);
        }
        public void Done()
        {
            Console.WriteLine();
        }


    }
}

using System;
using System.Linq;
using System.Collections.Generic;

namespace FizzBuzz
{
    public class ConsolePrinter : IWriteBuffer
    {

        public void Buffer(string toPrint)
        {

            Console.Write(toPrint);
        }
        public void Flush()
        {
            Console.WriteLine();
        }


    }
}

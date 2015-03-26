using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    public interface IPrinter
    {
        void Print(string toPrint);
        void Done();
    }
}

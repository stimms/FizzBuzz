using System;
using FizzBuzz;
using System.Linq;
using System.Collections.Generic;

namespace FizzBuzzTests
{
    public class FakePrinter : IPrinter
    {

        public List<string> Printed = new List<string>();
        public void Print(string toPrint)
        {
            Printed.Add(toPrint);
        }

        public bool doneCalled;
        public void Done()
        {
            doneCalled = true;
        }
    }
}

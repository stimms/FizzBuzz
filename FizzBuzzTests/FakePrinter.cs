using System;
using FizzBuzz;
using System.Linq;
using System.Collections.Generic;

namespace FizzBuzzTests
{
    public class FakePrinter : IWriteBuffer
    {

        public List<string> Printed = new List<string>();
        public void Buffer(string toPrint)
        {
            Printed.Add(toPrint);
        }

        public bool doneCalled;
        public void Flush()
        {
            doneCalled = true;
        }
    }
}

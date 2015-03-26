using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    public interface IWriteBuffer
    {
        void Buffer(string toPrint);
        void Flush();
    }
}

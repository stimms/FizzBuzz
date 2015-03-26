using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    public class Rule
    {

        public int Key { get; set; }
        public string Text { get; set; }

        public bool Matches(int key)
        {
            return key % Key == 0;
        }

        public string Execute()
        {
            return Text;
        }

    }
}

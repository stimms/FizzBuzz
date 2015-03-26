using System;
using System.Linq;
using System.Collections.Generic;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrinter printer = new ConsolePrinter();

            List<Rule> fizBuzzRuleSet = new List<Rule>{
                            new Rule{ Key = 3, Text = "Fizz"},
                            new Rule{ Key = 5, Text = "Buzz"}
                        };
            var fizzBuzzGenerator = new FizzBuzzGenerator(printer, fizBuzzRuleSet);

            for (int i = 1; i <= 100; i++)
            {
                fizzBuzzGenerator.Generate(i);
            }

            Console.ReadLine();
        }
    }
}

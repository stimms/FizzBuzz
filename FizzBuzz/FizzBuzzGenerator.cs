using System;
using System.Linq;
using System.Collections.Generic;

namespace FizzBuzz
{
    public class FizzBuzzGenerator
    {
        private readonly IPrinter _printer;
        private readonly IEnumerable<Rule> _rules;
        public void Generate(int i)
        {
            var matchingRules = _rules.Where(x => x.Matches(i));
            if (matchingRules.Any())
            {
                foreach (var rule in matchingRules)
                    _printer.Print(rule.Execute());
            }
            else
                _printer.Print(i.ToString());
            _printer.Done();
        }

        public FizzBuzzGenerator(IPrinter printer, IEnumerable<Rule> rules)
        {
            _rules = rules;
            _printer = printer;
        }
    }

  
}

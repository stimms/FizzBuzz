using System;
using System.Linq;
using System.Collections.Generic;

namespace FizzBuzz
{
    public class FizzBuzzGenerator
    {
        private readonly IWriteBuffer _printer;
        private readonly IEnumerable<Rule> _rules;
        public void Generate(int i)
        {
            var matchingRules = _rules.Where(x => x.Matches(i));
            if (matchingRules.Any())
            {
                foreach (var rule in matchingRules)
                    _printer.Buffer(rule.Execute());
            }
            else
                _printer.Buffer(i.ToString());
            _printer.Flush();
        }

        public FizzBuzzGenerator(IWriteBuffer printer, IEnumerable<Rule> rules)
        {
            _rules = rules;
            _printer = printer;
        }
    }

  
}

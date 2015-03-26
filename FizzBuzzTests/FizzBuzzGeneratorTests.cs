using Xunit;
using System;
using FizzBuzz;
using System.Linq;
using SharpTestsEx;
using System.Collections.Generic;

namespace FizzBuzzTests
{
    public class FizzBuzzGeneratorTests
    {
        List<Rule> fizzBuzzRuleSet = new List<Rule>{
                                    new Rule{ Key =3, Text = "Fizz"},
                                    new Rule{ Key =5, Text = "Buzz"}
                                };

        [Fact]
        public void A_number_should_print()
        {
            var printer = new FakePrinter();
            var sut = new FizzBuzzGenerator(printer, fizzBuzzRuleSet);
            sut.Generate(1);

            printer.Printed.Count.Should().Be.EqualTo(1);
            printer.Printed[0].Should().Be.EqualTo("1");
        }
        [Fact]
        public void When_divisible_by_3_should_print_fizz()
        {
            var printer = new FakePrinter();
            var sut = new FizzBuzzGenerator(printer, fizzBuzzRuleSet);
            sut.Generate(3);

            printer.Printed.Count.Should().Be.EqualTo(1);

            printer.Printed[0].Should().Be.EqualTo("Fizz");
        }

        [Fact]
        public void When_divisible_by_5_should_print_buzz()
        {
            var printer = new FakePrinter();
            var sut = new FizzBuzzGenerator(printer, fizzBuzzRuleSet);
            sut.Generate(5);

            printer.Printed.Count.Should().Be.EqualTo(1);

            printer.Printed[0].Should().Be.EqualTo("Buzz");
        }

        [Fact]
        public void When_divisible_by_3_and_5_should_print_fizzbuzz()
        {
            var printer = new FakePrinter();
            var sut = new FizzBuzzGenerator(printer, fizzBuzzRuleSet);
            sut.Generate(15);

            printer.Printed.Count.Should().Be.EqualTo(2);

            printer.Printed[0].Should().Be.EqualTo("Fizz");
            printer.Printed[1].Should().Be.EqualTo("Buzz");
        }

        [Fact]
        public void Printer_should_be_done()
        {
            var printer = new FakePrinter();

            var sut = new FizzBuzzGenerator(printer, fizzBuzzRuleSet);
            sut.Generate(1);

            printer.doneCalled.Should().Be.True();
        }
    }
}
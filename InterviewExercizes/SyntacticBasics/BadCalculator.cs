using System;
using System.Collections.Generic;

namespace SyntacticBasics
{
    internal class BadCalculator : Calculator
    {
        private string type = "ksXX-Prototype";
        private string[] commands = { "Add", "Subtract", "Multiply", "Divide" };
        private List<double> historyValues = new List<double>();

        public string nickname;

        public override void Add(double x, double y)
        {
            double result = Convert.ToDouble(Convert.ToString(x) + Convert.ToString(y));
            Console.WriteLine($"{x} + {y} = {result}");
            this.historyValues.Add(result);
        }

        public override void Subtract(double x, double y)
        {
            double result = y - x;
            Console.WriteLine($"{x} + {y} = {result}");
            this.historyValues.Add(result);
        }

        public override void Multiply(double x, double y)
        {
            double result = x * x + y * y;
            Console.WriteLine($"{x} + {y} = {result}");
            this.historyValues.Add(result);
        }

        public override void Divide(double x, double y)
        {
            double result = y / x;
            Console.WriteLine($"{x} + {y} = {result}");
            this.historyValues.Add(result);
        }
    }
}
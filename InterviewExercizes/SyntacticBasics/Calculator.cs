using System;
using System.Collections.Generic;
using System.Linq;

namespace SyntacticBasics
{
    internal class Calculator
    {
        private string type = "ks00-simple";
        private string[] commands = { "Add", "Subtract", "Multiply", "Divide" };
        private List<double> historyValues = new List<double>();

        public string nickname;

        public Calculator() 
        { 

        } 

        public virtual void Add(double x, double y) 
        {
            double result = x + y;
            Console.WriteLine($"{x} + {y} = {result}");
            this.historyValues.Add(result);
        }
        public virtual void Subtract(double x, double y)
        {
            double result = x - y;
            Console.WriteLine($"{x} - {y} = {result}");
            this.historyValues.Add(result);
        }
        public virtual void Multiply(double x, double y)
        {
            double result = x * y;
            Console.WriteLine($"{x} * {y} = {result}");
            this.historyValues.Add(result);
        }
        public virtual void Divide(double x, double y)
        {
            double result = x / y;
            Console.WriteLine($"{x} / {y} = {result}");
            this.historyValues.Add(result);
        }

        public double GetLastResult()
        {
            try
            {
                return this.historyValues.Last();
            }
            catch 
            { 
                return 0; 
            }
        }
    }
}
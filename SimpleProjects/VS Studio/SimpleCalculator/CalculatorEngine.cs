using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public double Calculate(double a, double b, string operation)
        {
            
            if (operation.ToLower().Equals("add") || operation.Equals("+"))
            {
                Console.WriteLine($"Result of {a}+{b} = {a + b}");
                return a + b;
                    
            }
            else if (operation.ToLower().Equals("subtract") || operation.ToLower().Equals("minus") || operation.Equals("-"))
            {
                Console.WriteLine($"Result of {a}-{b} = {a - b}");
                return a - b;
                    
            }
            else if (operation.ToLower().Equals("multiply") || operation.ToLower().Equals("times") || operation.Equals("*"))
            {
                Console.WriteLine($"Result of {a}*{b} = {a * b}");
                return a * b;
                    
            }
            else if (operation.ToLower().Equals("divide") || operation.Equals("/"))
            {
                if (b == 0)
                {
                    throw new DivideByZeroException();  
                }
                Console.WriteLine($"Result of {a}/{b} = {a / b}");
                return a / b;
                    
            }
            else
            {
                Console.WriteLine($"Operation {operation} is not a supported function, please try again.");
                throw new ArgumentException("Invalid calculation operation");
            }
            
        }
    }
}

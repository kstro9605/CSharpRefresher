using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class SimpleCalculator
    {
        static void Main(string[] args)
        {
            InputValidation ipVal = new InputValidation();
            CalculatorEngine engine = new CalculatorEngine();  

            Console.WriteLine("Hello! Please enter the first number for calculation");
            double a = ipVal.ValidNumericalInput(Console.ReadLine()); 

            Console.WriteLine("Please enter the second number for calculation");
            double b = ipVal.ValidNumericalInput(Console.ReadLine());

            Console.WriteLine("Please enter the operation for calculation");
            string operation = Console.ReadLine();

            engine.Calculate(a, b, operation);

            Console.ReadLine();
        }

    }
}

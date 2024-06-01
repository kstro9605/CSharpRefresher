using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class InputValidation
    {
        public double ValidNumericalInputRetry(string input)
        {
            double num;
            if (!double.TryParse(input, out num))
            {
                while (true)
                {
                    Console.WriteLine("Not a valid numerical type please retry.");
                    if (double.TryParse(Console.ReadLine(), out num))
                    {
                        return num;
                    }
                }
            }
            else
            {
                return num;
            }
        }
        public double ValidNumericalInput(string input)
        {
            double num;
            if (!double.TryParse(input, out num))
            {
                throw new ArgumentException("Expected a Numerical Value");
            }
            return num; 
        }
    }
}

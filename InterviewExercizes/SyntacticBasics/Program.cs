using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyntacticBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            dataTypeUsages();
            operatorsUsage();
            conditionalStatementUsage();
            Console.ReadLine();
        }

        static void dataTypeUsages()
        {
            //min: -2,147,483,648
            //max: 2,147,483,647
            int wholeNumber = 12;
            //min: -9,223,372,036,854,775,808
            //max: 9,223,372,036,854,775,807
            long largeWhole = 2147483649;
            //6 to 7 decimal digits
            float decimalVal = 6.1234567F;
            //15 decimal digits
            double longDecimalVal = 5.12345678912345D;

            bool trueVal = true;

            char charVal = 'a';
            string greeting = "Hello World";

            //implicit casting: smaller type size to larger implcitily casts
            //ascii value of a is 97
            char characterA = 'a';
            int charValCast = characterA;
            long intValCast = charValCast;
            float longValCast = intValCast;
            double floatValCast = longValCast;
            double charToDouble = characterA;

            //Explicit Casting: 
            double myDouble = 118.5;
            int myInt = (int) myDouble;
            //myDouble converts to 118 as int and ascii character of 118 is v
            char doubleToChar = Convert.ToChar(Convert.ToInt32(myDouble));

            //arrays

            string[] fruits = { "Banana", "Cantelope", "Apple" };
            string redFruit = fruits[0];

            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);
            }

            foreach(String fruit in fruits) 
            {
                Console.WriteLine(fruit);
            }

            Array.Sort(fruits);
            foreach (string i in fruits)
            {
                Console.WriteLine(i);
            }
        }

        static void operatorsUsage()
        {
            ////Arithmetic
            int sum = 5 + 5;
            int difference = 10 - 8;
            int product = sum * difference;
            float quotient = sum / difference;
            int remainder =  5 % 2;
            int counter = 0;
            counter++;
            counter--;

            ////Assignment
            int value = 4;
            value += 6;
            value -= 5;
            value *= 4;
            value /= 4;
            value %= 3;

            //bitwise assignment
            //4 is 100 binary
            int x = 4;
            //5 is 101 binary AND operaion of 100 & 101  = 100 so result is 4
            x &= 5;

            //5 is 101 binary
            int y = 5;
            //2 is binary 10 OR operation of 101 and 10 is 111 so result is 7
            y |= 2;

            // ^= is XOR operand
            //9 is 1001
            int a = 9; 
            //5 is 0101
            int b = 5;
            //1001 XOR 0101 =  1100 = 15
            a ^= b;

            //Right shift 
            //42 =101010
            x = 42;
            //shifting 3 = 010101 -> 001010 -> 000101
            x >>= 3;

            //left Shift
            //42 = 101010
            x = 42;
            //shifting 3 == 1010100 -> 10101000 -> 101010000 = 336
            x <<= 3;

            ////Comparison
            x = 5;
            y = 10;
            bool equality = x == y; //false
            bool inequality = x != y; // true
            bool greater = x > y; //false
            bool less = x < y; //true
            bool greaterEqual = x >= y; //false
            bool lessEqual = x <= y; // true

            ////logical
            bool logAnd = true && true ; //true
            logAnd = false && true; //false
            bool logOr = true || false; //true
            logOr = true || true; //true
            logOr = false || false; //flase
            bool notLog = !true; //false
        }

        static void conditionalStatementUsage()
        {
            Console.WriteLine("Please enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 5) 
            {
                Console.WriteLine("Value is greater than 5");
            }
            else if (a < 5) 
            {
                Console.WriteLine("Value is less than 5");
            }
            else 
            {
                Console.WriteLine("Value is 5");
            }

            bool isEqualSingleLine = (a == 5) ? true : false;

            //Switch Statement
            String animal = "Cat";
            
            switch(animal)
            {
                case "Dog":
                    Console.WriteLine("Animal is dog");
                    break;
                case "Cat":
                    Console.WriteLine("Animal is Cat");
                    break;
                default: 
                    Console.WriteLine("Something else");
                    break;

            }
        }

        static void loopsUsage()
        {
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            do
            {
                Console.WriteLine("I will execute once regardless of ");
            }
            while (false);

            for (int j = 0 ; j < 5; j++)
            {
                Console.WriteLine(j);
            }

            String letters = "abcdefghijklmnopqrstuvwxyz";
            int counter = 0;
            foreach(char letter in letters)
            {
                counter++;
            }
            Console.WriteLine("There are  "+counter+ " Letters");

        }
    }
}

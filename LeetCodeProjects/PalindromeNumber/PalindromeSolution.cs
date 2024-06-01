using System;

namespace PalindromeNumber
{
    public class PalindromeSolution
    {
        public static void Main()
        {
            Console.WriteLine("Testing Palindromes");
            int x = 121;
            int y = -121;
            int z = 10;
            Console.WriteLine(IsPalindrome(x));
            Console.WriteLine(IsPalindrome(y));
            Console.WriteLine(IsPalindrome(z));
        }

        public static bool IsPalindrome(int x)
        {
            char[] intArray = x.ToString().ToCharArray();
            Array.Reverse(intArray);
            string reversed = new string(intArray);
            if(reversed.ToLower().Equals(x.ToString().ToLower())) 
            {
                return true;
            }

            return false;

        }
    }

}
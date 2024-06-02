using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddTwoNumbers
{
    public class Program
    {
        public static void Main()
        {
            Solution sol = new Solution();
            System.Console.WriteLine("You are given two non-empty linked lists representing two non-negative integers."+
            " The digits are stored in reverse order, and each of their nodes contains a single digit. "+
            "Add the two numbers and return the sum as a linked list.\n\nYou may assume the two numbers do not contain any leading zero, except the number 0 itself.");
            System.Console.WriteLine("Test cases are as follows:");
            System.Console.WriteLine("CASE 1: l1 = [2,4,3], l2 = [5,6,4]");
            System.Console.WriteLine("CASE 2: l1 = l1 = [0], l2 = [0]");
            System.Console.WriteLine("CASE 3: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]");

            int[] l1Arra = {2,4,3};
            int [] l2Arra = {5,6,4};
            ListNode l1 = sol.CreateListFromArray(l1Arra);
            ListNode l2 = sol.CreateListFromArray(l2Arra);

            ListNode ans1 = sol.AddTwoNumbers(l1,l2);

            int[] l1Arrb = {0};
            int[] l2Arrb = {0};
            l1 = sol.CreateListFromArray(l1Arrb);
            l2 = sol.CreateListFromArray(l2Arrb);

            ListNode ans2 = sol.AddTwoNumbers(l1,l2);

            int[] l1Arrc = {9,9,9,9,9,9,9};
            int[] l2Arrc = {9,9,9,9};
            l1 = sol.CreateListFromArray(l1Arrc);
            l2 = sol.CreateListFromArray(l2Arrc);

            ListNode ans3 = sol.AddTwoNumbers(l1,l2);

            ans1.PrintList();
            System.Console.WriteLine("Expected: [7,0,8]");
            ans2.PrintList();
            System.Console.WriteLine("Expected: [0]");
            ans3.PrintList();
            System.Console.WriteLine("Expected: [8,9,9,9,0,0,0,1]");

        }
    }
}
using System;
using System.Text;

namespace AddTwoNumbers
{
    public class Solution {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
            int num1;
            int num2;
            Int32.TryParse(GetReversedString(l1), out num1);
            Int32.TryParse(GetReversedString(l2), out num2);

            int sum = num1 + num2;
            
            Char[] outString = sum.ToString().ToCharArray();
            Array.Reverse(outString);

            ListNode returnVal = CreateListFromArray(outString);

            return returnVal;
        }

        public ListNode AddNode(int data)
        {
            ListNode newNode = new ListNode();
            newNode.val = data;
            newNode.next = null;
            return newNode;
        }

        public string GetReversedString(ListNode node)
        {
            StringBuilder sb = new StringBuilder();
            ListNode current = node;

            if(node == null)
            {
                return "0";
            }

            sb.AppendLine(node.val.ToString());
            while(current.next != null)
            {
                sb.Insert(0,current.next.val);
                current = current.next;
            }

            return sb.ToString();
        }

        public ListNode CreateListFromArray(char[] arr)
        {
            ListNode returnVal = new ListNode();
            returnVal.val = (int)(Char.GetNumericValue(arr[0]));

            ListNode current = returnVal;

            for(int i = 1; i < arr.Length; i++)
            {
                current.next = AddNode((int)(Char.GetNumericValue(arr[i])));
                current = current.next;
            }

            return returnVal;
        }

        
        public ListNode CreateListFromArray(int[] arr)
        {
            ListNode returnVal = new ListNode();
            returnVal.val = arr[0];

            ListNode current = returnVal;

            for(int i = 1; i < arr.Length; i++)
            {
                current.next = AddNode(arr[i]);
                current = current.next;
            }

            return returnVal;
        }
    }
}
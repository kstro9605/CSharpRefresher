using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddTwoNumbers
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null) {
            this.val = val;
            this.next = next;
        }

        public void PrintList()
        {
            if(this == null)
            {
                System.Console.WriteLine("Empty List");
            }

            System.Console.Write($"[{this.val}");
            ListNode current = this;
            while(current.next != null)
            {
                current = current.next;
                System.Console.Write($",{current.val}");
            }
            System.Console.Write("]");
        }
    }
}
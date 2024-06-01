using System;

namespace DataStructures;

public class TestLinkedLists
{
    public static void Test()
    {
        LinkedListImpl.CallLinkedListPrint();
        LinkedListImpl.CallLinkedListRemove();

        System.Console.WriteLine("Working on manual Linked List");
        Node head = new Node("A");
        SinglyLinkedListManual list1 = new SinglyLinkedListManual(head);
        list1.PrintNodes();

        System.Console.Write("\nTest of add first ");
        list1.AddFirst("D");
        list1.AddFirst("C");
        list1.AddFirst("B");
        list1.PrintNodes();
        System.Console.WriteLine($"Head is {list1.getFirst()}");
        System.Console.WriteLine($"Head is {list1.getLast()}");

        System.Console.Write("\nTest of add last ");
        list1.AddLast("E");
        list1.AddLast("F");
        list1.PrintNodes();
        System.Console.WriteLine($"Head is {list1.getFirst()}");
        System.Console.WriteLine($"Head is {list1.getLast()}");

        list1.PrintSize();

        System.Console.WriteLine("\nTesting addFirst after last");
        list1.AddFirst("B{Sub}");
        list1.PrintNodes();
        System.Console.WriteLine($"Head is {list1.getFirst()}");
        System.Console.WriteLine($"Head is {list1.getLast()}");

        System.Console.WriteLine("\nRemoving first non head Node");
        list1.RemoveFirst();
        list1.PrintNodes();
        System.Console.WriteLine($"Head is {list1.getFirst()}");
        System.Console.WriteLine($"Head is {list1.getLast()}");

        System.Console.WriteLine("\nRemoving Last Node");
        list1.RemoveLast();
        list1.PrintNodes();
        System.Console.WriteLine($"Head is {list1.getFirst()}");
        System.Console.WriteLine($"Head is {list1.getLast()}");

        list1.PrintSize();

        System.Console.WriteLine("\nFinding nodes");
        Node foundNode = list1.find("C");
        System.Console.WriteLine($"Node found with data: {foundNode.data} and next pointer value as {foundNode.nextPointer.data}");
    }
}
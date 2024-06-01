
// C# program to illustrate how 
// to create a LinkedList
using System;
using System.Collections.Generic;
 
class LinkedListImpl {
 
    // Main Method
    static public void CallLinkedListPrint()
    {
 
        // Creating a linkedlist
        // Using LinkedList class
        LinkedList<String> linkedListTest = new LinkedList<String>();
 
        // Adding elements in the LinkedList
        // Using AddLast() method
        linkedListTest.AddLast("1");
        linkedListTest.AddLast("2");
        linkedListTest.AddLast("3");
        linkedListTest.AddLast("4");
 
        Console.WriteLine("All elements in Linked List:");
 
        // Accessing the elements of 
        // LinkedList Using foreach loop
        foreach(string str in linkedListTest)
        {
            Console.WriteLine(str);
        }
    }

    static public void CallLinkedListRemove()
    {
 
        // Creating a linkedlist
        // Using LinkedList class
        LinkedList<String> linkedListTest = new LinkedList<String>();
 
        // Adding elements in the LinkedList
        // Using AddLast() method
        linkedListTest.AddLast("1");
        linkedListTest.AddLast("2");
        linkedListTest.AddLast("3");
        linkedListTest.AddLast("4");
 
        Console.WriteLine("All elements in Linked List after removal:");
 
        linkedListTest.RemoveFirst();
        linkedListTest.RemoveLast();
        linkedListTest.Remove("2");
        foreach(string str in linkedListTest)
        {
            Console.WriteLine(str);
        }
    }
}

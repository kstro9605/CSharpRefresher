using System.Security.Cryptography.X509Certificates;

public class Node 
{
    public Node nextPointer;
    public Object data;

    public Node(Object data = null, Node next = null)
    {
        this.data = data;
        nextPointer = next;
    }
}

public class SinglyLinkedListManual
{
    private Node head;
    private Node tail;
    private int Size;



    public SinglyLinkedListManual(Node head)
    {
        this.head = head;
        this.tail = head;
        Size = 1;
    }

    public void PrintNodes()
    {
        Node currentHead = head;
        System.Console.WriteLine("Printing Linked List");
        //assuming non circular LinkedList
        while(currentHead != null)
        {
            System.Console.Write(currentHead.data + " -> ");
            currentHead = currentHead.nextPointer;
        }
        System.Console.Write("null\n");
    }

    //First being the next non head Node in the list
    public void AddFirst(Object data)
    {
        //create and populate the node to add
        Node objToAdd = new Node(data, head.nextPointer);

        //grabs the current list head node, which should be the first element right?
        Node current = head;

        current.nextPointer = objToAdd;
        this.Size++;
        while(current.nextPointer != null)
        {
            current = current.nextPointer;
        }
        this.tail = current;
    }

    public void AddLast(Object data)
    {
        //create and populate the node to add
        Node objToAdd = new Node(data);

        //grabs the current list head node, which should be the first element right?
        Node current = head;
        while(current.nextPointer != null)
        {
            current = current.nextPointer;
        }

        current.nextPointer = objToAdd;
        Size++;
        tail = current.nextPointer;
    }

    public void RemoveFirst()
    {
        if (this.Size == 0)
        {
            throw new InvalidOperationException("The size of this linked list does not support this operation");
        }
        Node newFirst = head.nextPointer.nextPointer;
        head.nextPointer = newFirst;
        this.Size--;
        //TODO figure out garbage collection to optimize this function further
    }
    
    public void RemoveLast()
    {
        if (this.Size == 0 )
        {
            throw new InvalidOperationException("The size of this linked list does not support this operation");
        }
        Node current = head;
        while(!current.nextPointer.Equals(this.tail))
        {
            current = current.nextPointer;
            
        }
        this.tail = current;
        current.nextPointer = null;
        this.Size--;
        //TODO figure out garbage collection to optimize this function further
    }
    public Node find(Object value)
    {
        Node current = head;
        while(current.nextPointer != null)
        {
            if (current.data.Equals(value))
            {
                return current;
            }
            current = current.nextPointer;
        }
        return null;
    }

    public void PrintSize()
    {
        System.Console.WriteLine($"Size of singly linked list is {this.Size}");
    }

    public string getFirst()
    {
        return $"Head is {head.data}";
    }

    public string getLast()
    {
        return $"Tail is {tail.data}";
    }
}
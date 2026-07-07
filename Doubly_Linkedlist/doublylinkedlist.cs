using Boubly_LinkedList.Node;
public class doublylinkedlist
{
    Node head=null;
    Node current =null;

    public void InsertAtFront(int Data)
    {
        Node newNode=new Node(Data);

        if (head == null)
        {
            head = newNode;
        }
        else
        {
            newNode.Next=head;
            head.Previous=newNode;
            newNode.Previous=null;
            head=newNode;
        }
    }

    public void InsertAtEnd(int data)
    {
        Node newNode=new Node(data);
        {
            current=head;

            while (current.Next != null)
        {
            current=current.Next;
        }
        current.Next=newNode;
        newNode.Previous=current;
        }
    }

    public void Display()
    {
        Node current=head;
        while (current != null)
        {
            Console.WriteLine(current.Data + "");
            current=current.Next;
        }
        Console.WriteLine();

    }

}

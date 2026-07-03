
namespace Linked_List.Node;
public class LinkedList
{
    Node head=null;

    public void AddLast(int data)
    {
        Node newNode=new Node(data);
        

        if (head == null)
        {
            head=newNode;

        }
        else
        {
            Node current=head;
            while (current.Next != null)
            {
                current=current.Next;
            }
            current.Next=newNode;
        }
    }

        public void AddFirst(int data)
        {
            Node newNode=new Node(data);

            if (head == null)
            {
                head=newNode;
            }
            else
            {
                newNode.Next=head;
                head=newNode;
                
            }

        }

    public void Display()
    {
        Node current=head;
        while (current != null)
        {
            Console.WriteLine(current.Data);
            current=current.Next;
        }
    }

    public void Update(int old_value,int new_value)
    {
        if (head == null)
        {
            Console.WriteLine("Empty");
            return;
        }
        Node current=head;
        while (current != null)
        {
            if (current.Data == old_value)
            {
                current.Data=new_value;
                Console.WriteLine("Updated");
                return;
            }
            current=current.Next;
        }
        Console.WriteLine("node not found");
    }

    public void Remove(int value)
        {
            if(head==null)
            {
                Console.WriteLine("Empty");
                return;
            }

            if(head.Data==value)
            {
                head=head.Next;
                Console.WriteLine("Deleted");
                return;
            }

            Node Current=head;

            while(Current.Next!=null)
            {
                if(Current.Next.Data==value)
                {
                    Current.Next=Current.Next.Next;

                    Console.WriteLine("Deleted");

                    return;
                }

                Current=Current.Next;
            }

            Console.WriteLine("Node Not Found");
        }

        public void InsertInBetween(int data)
            {
                Node newNode = new Node(data);

                // If the list is empty or the new node should be the first node
                if (head == null || head.Data >= data)
                {
                    newNode.Next = head;
                    head = newNode;
                    return;
                }

                Node current = head;

                // Traverse until the correct position is found
                while (current.Next != null && current.Next.Data < data)
                {
                    current = current.Next;
                }

                // Insert the new node
                newNode.Next = current.Next;
                current.Next = newNode;
            }           
}
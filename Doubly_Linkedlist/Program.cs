using Boubly_LinkedList.Node;

public class program
{
    public static void Main(String[] args)
    {
        doublylinkedlist dll=new doublylinkedlist();
        

        dll.InsertAtFront(10);
        dll.InsertAtFront(5);
        dll.InsertAtFront(21);
        dll.InsertAtFront(21);
        dll.InsertAtEnd(30);
        dll.InsertAtEnd(50);
         dll.DeleteFront();
         dll.Display();
    
        
    }
}
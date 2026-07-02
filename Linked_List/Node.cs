using System;
namespace Linked_List.Node;
class Node
{
    public int Data;
    public Node Next;


    public Node()
    {
        
    }

    public Node(int data)
    {
        Data=data;
        Next=null;
    }
}

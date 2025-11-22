using System;
namespace Transflower{
public class Node
{
    public Node Next{get;set;}
    public int Data{get;set;}


public Node()
    {
        this.Next=null;
        this.Data=0;
    }

    public Node(int data)
        {
           this.Next=null;
            this.Data=data;
        }
}
}
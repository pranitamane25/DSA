using System;

class Node
{
    public int Data;
    public Node Next;
}

class Program
{
    static void Main()
    {
        Node n1 = new Node();
        n1.Data = 10;

        Node n2 = new Node();
        n2.Data = 20;

        Node n3 = new Node();
        n3.Data = 30;

        n1.Next = n2;
        n2.Next = n3;
        n3.Next = null;

        Node temp = n1;

        while (temp != null)
        {
            Console.WriteLine(temp.Data);
            temp = temp.Next;
        }
    }
}
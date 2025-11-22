using System;

namespace Transflower
{
    public class LinkedList
    {
        private Node startNode=null;   

        public LinkedList()
        {
            startNode = null;     
        }

        public void insert(int value)
        {
            Node newNode = new Node(value);
            if (startNode == null)
            {
                startNode = newNode;
            }

            else
            {
                Node temp = startNode;
                
                while (temp.Next != null)
                    temp = temp.Next; 
            
                temp.Next = newNode;
            }
              
        }

      
        public void delete(int value)
        {
            if (startNode == null) return;

            if (startNode.Data == value)
            {
                startNode = startNode.Next;
                return;
            }

            Node current = startNode;
            while (current.Next != null && current.Next.Data != value)
                current = current.Next;

            if (current.Next != null)
                current.Next = current.Next.Next;
        }

          public void display()
        {
            Node current = startNode;
            while (current != null)
            {
                Console.WriteLine(current.Data+"");
                current = current.Next;
            }
            Console.WriteLine("*****\n");
        }

    }
}

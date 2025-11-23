
using System;
using transflower;

namespace transflower
{
    public class Shelf
    {
        public const int size = 5;
        public int top;
        public Book[] book = new Book[size];

        public Shelf()
        {
            this.top = -1;
        }

        public void Push(Book theBook)
        {
            if (top < size - 1)
            {
                top++;
                book[top] = theBook;
            }
            else
            {
                Console.WriteLine("Stack is full");
            }
        }

        public Book Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty");
                return null;
            }

            Book b1 = book[top];
            // book[top] = null; 
            top--;
            return b1;
        }

        public void Display()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty");
                return;
            }

            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(book[i].ToString());
            }
        }
    }
}

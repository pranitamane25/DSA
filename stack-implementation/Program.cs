using System;

namespace transflower
{
    public class Program
    {
        public static void Main()
        {
            int choice;
            Shelf motivationalBook = new Shelf();

            Console.WriteLine("Menu");
            Console.WriteLine("1. Add new book");
            Console.WriteLine("2. Remove the top book");
            Console.WriteLine("3. Display books");
            Console.WriteLine("4. Exit");

            do
            {
                Console.WriteLine();
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            Console.Write("Enter book id: ");
                            int id = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Enter book title: ");
                            string title = Console.ReadLine();

                            Console.Write("Enter book author: ");
                            string author = Console.ReadLine();

                            Book newBook = new Book();
                            newBook.id = id;
                            newBook.title = title;
                            newBook.author = author;

                            motivationalBook.Push(newBook);
                            Console.WriteLine("Book pushed");
                            break;
                        }

                    case 2:
                        {
                            Book poppedBook = motivationalBook.Pop();

                            if (poppedBook != null)
                            {
                                Console.WriteLine("Book popped: " + poppedBook.title);
                            }
                            break;
                        }

                    case 3:
                        {
                            motivationalBook.Display();
                            break;
                        }

                    case 4:
                        {
                            Console.WriteLine("Exiting...");
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Invalid choice! Try again.");
                            break;
                        }
                }

            } while (choice != 4);
        }
    }
}

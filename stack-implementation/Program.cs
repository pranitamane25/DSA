
using System;

namespace transflower
{
    public class Program
    {
        public static void Main()
        {
            int choice = 0;
            var motivationalBook = new Shelf();

            Console.WriteLine("Menu");
            Console.WriteLine("1. Add new book");
            Console.WriteLine("2. Remove the top book");
            Console.WriteLine("3. Display books");
            Console.WriteLine("4. Exit");

            do
            {
                Console.WriteLine();
                Console.Write("Enter your choice: ");
                string input = Console.ReadLine();
                if (!int.TryParse(input, out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        {
                            Console.Write("Enter book id: ");
                            if (!int.TryParse(Console.ReadLine(), out int id))
                            {
                                Console.WriteLine("Invalid id. Aborting add.");
                                break;
                            }

                            Console.Write("Enter book title: ");
                            string title = Console.ReadLine() ?? "";

                            Console.Write("Enter book author: ");
                            string author = Console.ReadLine() ?? "";

                            Book newBook = new Book { id = id, title = title, author = author };

                            motivationalBook.Push(newBook);
                            Console.WriteLine("Book pushed");
                            break;
                        }

                    case 2:
                        {
                            Book poppedBook = motivationalBook.Pop();

                            if (poppedBook != null)
                                Console.WriteLine("Book popped: " + poppedBook.title);

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

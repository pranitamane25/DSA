using System;

namespace Transflower
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            int choice = 0;

            while (choice != 4)
            {
                Console.WriteLine("Linked List Menu");
                Console.WriteLine("1. Insert Node");
                Console.WriteLine("2. Delete Node");
                Console.WriteLine("3. Display List");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter value to insert: ");
                        int insertValue = Convert.ToInt32(Console.ReadLine());
                        list.insert(insertValue);
                        Console.WriteLine("Node Inserted!");
                        break;

                    case 2:
                        Console.Write("Enter value to delete: ");
                        int deleteValue = Convert.ToInt32(Console.ReadLine());
                        list.delete(deleteValue);
                        Console.WriteLine("Node Deleted (if existed)!");
                        break;

                    case 3:
                        Console.WriteLine("Linked List:");
                        list.display();
                        break;

                    case 4:
                        Console.WriteLine("Exiting program...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Try again.");
                        break;
                }
            }
        }
    }
}

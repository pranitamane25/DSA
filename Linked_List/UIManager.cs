namespace Linked_List.UIManager;
using Linked_List.Node;
using System;
public class UIManager
{
        LinkedList list=new LinkedList();
    public void start(){

    bool exit=false;
    while(!exit){

        Console.WriteLine("=====LinkedList Operations=====");
        Console.WriteLine("1.AddLast");
        Console.WriteLine("2.Display ");
        Console.WriteLine("3.Update ");
        Console.WriteLine("4.Remove");
        Console.WriteLine("5.Add First");
        Console.WriteLine("6.InsertInBetween");
        Console.WriteLine("7.Invalid");

        int choice=Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                Console.WriteLine("Enter number to AddLast");
                int num=Convert.ToInt32(Console.ReadLine());
                list.AddLast(num);
                Console.WriteLine("number added to list");
                break;


                case 2:
                Console.WriteLine("Display list");
                list.Display();
                break;

                case 3:
                Console.WriteLine("old value:");
                int old_value=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("new value");
                int new_value=Convert.ToInt32(Console.ReadLine());
                list.Update(old_value,new_value);
                break;

                case 4:
                Console.Write("Enter Value : ");
                int value=Convert.ToInt32(Console.ReadLine());
                list.Remove(value);
                break;

                case 5:
                Console.WriteLine("Enter add first value");
                int AddFirst=Convert.ToInt32(Console.ReadLine());
                list.AddFirst(AddFirst);
                break;

                case 6:
                Console.WriteLine("Enter number which you wnat to insert inbetween");
                int InsertInBetween=Convert.ToInt32(Console.ReadLine());
                list.InsertInBetween(InsertInBetween);
                break;

                default:
                Console.WriteLine("Invalid choice");
                return;
            }
    }
    }

}
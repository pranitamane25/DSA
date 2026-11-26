public class Calculator{
    public static void Main(String[] args){

        Console.WriteLine("Addition");
        Console.WriteLine("Subtraction");
        Console.WriteLine("Multiplication");
        Console.WriteLine("Division");

        Console.WriteLine("Enter your choice");
        int choice=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter 1st number");
        int num1=Convert.ToInt32 (Console.ReadLine());
          Console.WriteLine("Enter 2nd number");
        int num2=Convert.ToInt32 (Console.ReadLine());

        switch (choice)
        {
            case 1:
            Console.WriteLine("Addition "  + ( num1 +  num2));
           break;

           case 2:
           Console.WriteLine("Subtraction:"+(num1 - num2));
           break;

           case 3:
           Console.WriteLine("Multiplication"+ (num1 * num2));
           break;

           case 4:
                if (num2 != 0)
                {
                    Console.WriteLine("Division:" + num1/num2);
                }
                else
                {
                    Console.WriteLine("Cannot devided by zero");
                }         
           break;
           
           default:
           Console.WriteLine("Invalid choice");
           break;

        }

    }
}
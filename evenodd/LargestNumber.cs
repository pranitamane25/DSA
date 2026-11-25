public class LargestNumber{
    public static void Main(String[] args){
        
        Console.WriteLine("enter 1st number");
        int num1=Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("enter 2nd number");
        int num2=Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("enter 3rd number");
        int num3=Convert.ToInt32(Console.ReadLine());

        if (num1 > num2 && num1 >num3)
        {
            Console.WriteLine("num1 is gretest");
        }
        else if(num2 > num1 && num2 >num3)
        {
            Console.WriteLine("num2 is gretest");
        }
        else
        {
            Console.WriteLine("num3 is gretest");
        }

    }
}
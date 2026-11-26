public class Multiplication
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number:");
        int num=Convert.ToInt32(Console.ReadLine());

        for(int i = 1; i <= 10; i++)
        {
            Console.WriteLine(num+"x"+i+"="+num*i);
        }
    }
}
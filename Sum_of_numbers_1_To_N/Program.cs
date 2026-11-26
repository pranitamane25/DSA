public class Sum
{
    static void Main(String[] args)
    {
        Console.WriteLine("Enter the number:");
        int num=Convert.ToInt32(Console.ReadLine());

        int sum=0;

        for(int i = 1; i <= num; i++)
        {
            sum=sum+i;
        }
        Console.WriteLine("Sum of the given numbers:" + sum);
    }
}
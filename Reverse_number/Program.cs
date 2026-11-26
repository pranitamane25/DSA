public class ReverseNumber{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter the number which you want to reverse");
        int num=Convert.ToInt32(Console.ReadLine());

        int reverse=0;

        while (num > 0)
        {
            int digit=num%10;
            reverse=reverse*10+digit;
            num=num/10;
        }
        Console.WriteLine("reverse number:" +reverse);
    }
}
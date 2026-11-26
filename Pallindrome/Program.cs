public class Pallindrome{
    public static void Main(String[] args){

        Console.WriteLine("Enter a number");
        int num=Convert.ToInt32(Console.ReadLine());

        int original= num;
        int reverse=0;

        while (num > 0)
        {
            int digit=num%10;
             reverse=reverse*10+digit;
             num=num/10;
        }
        if (original == reverse)
        {
            Console.WriteLine("Pallindrome");
        }
        else
        {
            Console.WriteLine("Not Pallindrome");
        }

    }
}
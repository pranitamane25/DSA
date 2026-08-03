//reverse numbers
public class Program{
    public static void Main(){

        int num=12345;
        int reverse=0;

        while (num > 0)
        {
            int digit =num%10;
            reverse=reverse*10+digit;
            num=num/10;
        }
        Console.WriteLine(reverse);

    }
}
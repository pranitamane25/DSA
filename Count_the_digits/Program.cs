public class count
{
    public static void Main(String[] args){

        Console.WriteLine("Enter the digits:");
        int num=Convert.ToInt32(Console.ReadLine());

        int count=0;

        while (num > 0)
        {
            num=num/10;
            count++;
        }
        Console.WriteLine("Digit count:"+count);
    }
}
public class Program{
    public static void Main(){
        int num=1234578903;
        int count=0;

        while (num > 0)
        {
            count++;
            num=num/10;
        }
        Console.WriteLine(count);
    }
}
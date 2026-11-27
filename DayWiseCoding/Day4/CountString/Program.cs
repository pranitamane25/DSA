public class StringCount{
    public static void Main(string[] args){

        Console.WriteLine("Enter the string");
        string str=Convert.ToString(Console.ReadLine());

        int count=str.Length;
        Console.WriteLine("String length : " + count);
    }
}
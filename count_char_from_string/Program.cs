using System.Reflection.PortableExecutable;

public class Program{
    public static void Main(){

        string str="Hello pranita";
        int count=0;

        for(int i = 0; i < str.Length; i++)
        {
            count++;
        }
        Console.WriteLine("Characters count : " + count);
    }
}

//reverse string 


public class Program{
    public static void Main()
    {
        string str="Pranita";

        string reverse="";

        for(int i = str.Length - 1; i >= 0; i--)
        {
            reverse+=str[i];
        }
        Console.WriteLine(reverse);

    }
}
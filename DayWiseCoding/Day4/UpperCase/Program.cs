
public class UpperCase{
    static void Main(string[] args){

        Console.WriteLine("Enter a string");
        string str=Convert.ToString(Console.ReadLine());

        string upper=str.ToUpper();
        Console.WriteLine(upper);
    }
}
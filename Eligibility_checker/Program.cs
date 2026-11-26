public class Eligibility_Checker{
    public static void Main(string[] args){

        Console.WriteLine("Enter your age");
        int age=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Does the person have valid Id:");
        bool id=Convert.ToBoolean(Console.ReadLine());   

        if(age>=18 && id == true)
        {
            Console.WriteLine("Eligible");
        }
        else
        {
            Console.WriteLine("not eligible");
        }
    }
}
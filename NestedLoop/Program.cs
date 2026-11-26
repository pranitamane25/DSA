public class Nestedloop{
    public static void Main(String[] args){

        for(int i = 1; i <= 5; i++)
        {
            for(int j = 1; j <= 5; j++)
            {
                Console.Write("*");
            }
              Console.WriteLine(" ");
        }
    }
}
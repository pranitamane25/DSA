public class CalculateTotal{
    public static void Main(string[] args){
        int[] num={10,20,30,40,50};

        int total=0;

        for(int i = 0; i < num.Length; i++)
        {
            total=total+num[i];
        }

        Console.WriteLine("Total of array:"+ total);
    }
}
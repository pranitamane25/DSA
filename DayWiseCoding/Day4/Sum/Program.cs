public class Sum{
    public static void Main(string[] args){

        int[] arr={10,20,30,40,50,50};

        int total=0;

        for(int i = 0; i < arr.Length; i++)
        {
            total=total+arr[i];
        }

        Console.WriteLine("total of array:" + total);
    }
}
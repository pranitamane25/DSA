public class PrintArray{
    public static void Main(string[] args){

        int[] arr={10,20,30,40,50,60,70};

        for(int i = 0; i < arr.Length ; i++)
        {
            Console.WriteLine("Array Elements:" + arr[i]);
        }
    }
}
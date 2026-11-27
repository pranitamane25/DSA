public class SmallestNumber{
    public static void Main(string[] args)
    {
        int[] arr={2,34,56,78,9};
        
        int smallest=arr[0];

        for(int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < smallest)
            {
                smallest=arr[i];
            }
        }
        Console.WriteLine("Smallest Number:" + smallest);
    }
}
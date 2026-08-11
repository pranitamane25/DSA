public class Program{
    public static void Main()
    {
        
        int[]arr={10,20,49,50,70};
        int largest=arr[0];

        for(int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > largest)
            {
                largest=arr[i];
            }

        }
        Console.WriteLine(largest);
        
    }
}
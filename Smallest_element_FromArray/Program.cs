public class Program{
    public static void Main()
    {
        int[] arr={10,30,40,2,50};
        int smallest=arr[0];

        for(int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < smallest)
            {
                smallest=arr[i];
            }          
        }
    Console.WriteLine("Smallest Element From array :" +smallest );
    }  
}
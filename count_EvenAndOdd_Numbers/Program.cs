public class Program{
    public static void Main()
    {
        int even=0;
        int odd=0;
        int num=0;
        

        int[] arr={10,20,31,89,80};

        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i]%2==0){
            even++;
            }
            else
            {
                odd++;
            }
            
        }
        Console.WriteLine("even Numbers:" +even);
        Console.WriteLine("Odd numbers:" +odd);

    }
}
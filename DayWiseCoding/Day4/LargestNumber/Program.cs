public class Largest{
    public static void Main(string[] args){

        int largest=0;

        int[] arr={12,34,56,78,90};

        for(int i = 1; i < arr.Length; i++)
        {
            if ( arr[i]>largest)
            {
                largest=arr[i];
            }
        }
        
        Console.WriteLine("Largest Number:" +largest);
    }
    }

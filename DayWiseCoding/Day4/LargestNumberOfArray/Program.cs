public class LargestNumber{
    public static void Main(string[] args){

        int[] array={10,20,30,40,50};
        int largest=array[0];

        for(int i = 1; i < array.Length; i++)
        {
           if( array[i]> largest)
            {
                largest=array[i];
            }
        }
            Console.WriteLine("Largest number is:" +largest);

        }
    }

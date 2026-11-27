public class CalculateAverage{
    public static void Main(string[] args){

        int total=0;

        int[] array={10,20,30,40,50,60};

        for(int i = 0; i < array.Length; i++)
        {
            total=total+array[i];
        }
             int average=total/array.Length;
        
        Console.WriteLine("Average of the array :" + average);
    }
}
public class EvenOdd{
    public static void Main(string[] args){
        bool result=EvenOddCheck(40);
        Console.WriteLine(result);
    }
        public static bool EvenOddCheck(int a)
        {
            if(a % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

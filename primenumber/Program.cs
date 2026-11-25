class Prime{
    public static void Main(String[] args)
    {
        for(int num=2; num <= 20; num++)
        {
            bool isPrime=true;
        
        for(int i = 2; i < num; i++)
        {
                if (num % i == 0)
                {
                    isPrime=false;
                    break;
                }
        }
            if (isPrime)
            {
                Console.WriteLine(num);
            }
    }
}
}
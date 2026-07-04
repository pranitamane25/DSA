

//List <int> numbers=new List <int>(){10,20,30,40,50};

// foreach(int num in numbers)
// {
//     Console.WriteLine(num);
// }

//take user input and display list

List <int> numbers=new List <int>();

Console.WriteLine("Display numbers");

for(int i = 0; i < 5; i++)
{
    int num=Convert.ToInt32(Console.ReadLine());
    numbers.Add(num);
}

Console.WriteLine("List Elements");

for(int i = 0; i < numbers.Count; i++)
{
    Console.WriteLine(numbers[i]);
}
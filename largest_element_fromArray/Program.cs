
//Find largest element from array

int [] arr={10,29,30,40,80};

int largest=arr[0];

for(int i = 1; i < arr.Length; i++)
{
    if (arr[i] > largest)
    {
        largest=arr[i];
    }
}

Console.WriteLine("Largest Element :" + largest);

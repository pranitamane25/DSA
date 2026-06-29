//transpose matrix ---rows are convert into the cloumns and vice versa==>[1,0]=[0,1]


int[,] arr =
{
    {1,2,3},
    {4,5,6},
    {7,8,9}
};

int rows=arr.GetLength(0);
int cols=arr.GetLength(1);

int[,]transpose=new int[rows,cols];
for(int i=0;i< rows; i++)
{
    for(int j = 0; j < cols; j++)
    {
        transpose[j,i]=arr[i,j];
    }
}

Console.WriteLine("Transpose Matrix");

for(int i = 0; i < rows; i++)
{
    for(int j = 0; j < cols; j++)
    {
        Console.Write(transpose[i,j]+" ");
    }
    Console.WriteLine();
}

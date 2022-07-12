int[]numbers=new int[123];

int size=0;

FillArray(numbers);
PrintArray(numbers);

for(int i=0;i < numbers.Length; i++)
{
    if(numbers[i]>9 && numbers[i]<100)
    {
        size=size+1;
    }
}

Console.WriteLine($"->{size}");



void FillArray (int[] array)
{
    for(int i=0;i< array.Length; i++)
    {
        array[i]= new Random().Next(0,150);
    }
}


void PrintArray (int[] array)
{
    for(int i=0;i< array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }
    Console.WriteLine();
}

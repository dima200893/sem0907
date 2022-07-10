int size= InputInt("Введите размер ");

int[]numbers=new int[size];

int summ=0;

FillArray(numbers);
PrintArray(numbers);

for(int i=0;i < numbers.Length; i++)
{
    if(i%2!=0)
    {
        summ= summ + numbers[i];
    }
}

Console.WriteLine($"->{summ}");











int InputInt(string output)
{
    Console.WriteLine(output);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray (int[] array)
{
    for(int i=0;i< array.Length; i++)
    {
        array[i]= new Random().Next(-10,10);
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

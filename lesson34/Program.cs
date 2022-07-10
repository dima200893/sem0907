int size= InputInt("Введите размер ");

int[]numbers=new int[size];

int count=0;

FillArray(numbers);
PrintArray(numbers);

for(int i=0;i < numbers.Length; i++)
{
    if(numbers[i]%2==0)
    {
        count=count+1;
    }
}

Console.WriteLine($"В данном массиве количетсво четных чисел = " + (count));











int InputInt(string output)
{
    Console.WriteLine(output);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray (int[] array)
{
    for(int i=0;i< array.Length; i++)
    {
        array[i]= new Random().Next(99,1000);
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

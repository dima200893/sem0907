int size= InputInt("Введите размер массива  ");

int[]numbers=new int[size];

int diff=0;

FillArray(numbers);
PrintArray(numbers);

int maxIndex=numbers[0];
int minIndex=numbers[0];


for(int i=1;i < numbers.Length; i++)
{

    if(numbers[i]>maxIndex)
    {
        maxIndex=numbers[i];
    }
    else if (numbers[i]<minIndex)
    {
        minIndex=numbers[i];
    }
}
Console.WriteLine("Масксимальное число ="+ maxIndex);
Console.WriteLine("Минимальное число =" + minIndex);
diff= maxIndex-minIndex;
Console.WriteLine("Разница максимального числа и минимального числа ="+ diff);














int InputInt(string output)
{
    Console.WriteLine(output);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray (int[] array)
{
    for(int i=0;i< array.Length; i++)
    {
        array[i]= new Random().Next(0,10);
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

int size= InputInt("Введите размер массива  ");

double[]numbers=new double[size];

double diff=0;

FillArray(numbers);
PrintArray(numbers);

double maxIndex=numbers[0];
double minIndex=numbers[0];


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

void FillArray (double[] array)
{
    for(int i=0;i< array.Length; i++)
    {
        array[i]= new Random().Next(0,10) + new Random().NextDouble();
    }
}


void PrintArray (double[] array)
{
    for(int i=0;i< array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }
    Console.WriteLine();
}

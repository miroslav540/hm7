// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.Clear();
Console.WriteLine("Введите кол-во строк и столбцов массива: "); 
int arrowSize = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента: "); 
int maxNumb = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное значчение элемента: "); 
int minNumb = int.Parse(Console.ReadLine());
Console.WriteLine("Массив со случайными значениями 1: ");
int[,] array = GetArray(arrowSize, maxNumb, minNumb);
int[,] GetArray(int arrowSize, int maxNumb, int minNumb)
{
    int[,] array = new int[arrowSize, arrowSize];
    for (int i = 0; i < arrowSize; i++)
    {
        for (int j = 0; j < arrowSize; j++)
        {
            array[i, j] = new Random().Next(minNumb, maxNumb + 1);
        }
    }
    return array;
}
int[,] secondArray = GetsecondArray(arrowSize, maxNumb, minNumb);
int[,] GetsecondArray(int arrowSize, int maxNumb, int minNumb)
{
    int[,] secondArray = new int[arrowSize, arrowSize];
    for (int i = 0; i < arrowSize; i++)
    {
        for (int j = 0; j < arrowSize; j++)
        {
            secondArray[i, j] = new Random().Next(minNumb, maxNumb + 1);
        }
    }
    return secondArray;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
void PrintsecondArray(int[,] secondArray)
{
    for (int i = 0; i < secondArray.GetLength(0); i++)
    {
        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            Console.Write(secondArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
void PrintSumArray(int[,] array, int[,] secondArray)
{
    int[,] sumArray = new int[array.GetLength(0), secondArray.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            sumArray[i,j] = array[i,j] * secondArray[i,j];
            Console.Write(sumArray[i,j] +"\t");
        }
        Console.WriteLine();
    }
}
PrintArray(array);
Console.WriteLine("-----------------------------------");
Console.WriteLine("Массив со случайными значениями 2: ");
PrintsecondArray(secondArray);
Console.WriteLine("-----------------------------------");
Console.WriteLine("Результат: ");
PrintSumArray(array, secondArray);
//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int rows = 4;
int columns = 4;

int[,] matrix = new int[rows, columns];

int minValue = int.MaxValue;
int indexRows = 0;
int indexColumns = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(1, 10);
        Console.Write(matrix[i, j] + "\t");
        if (minValue > matrix[i, j])
        {
            minValue = matrix[i, j];
            indexRows = i;
            indexColumns = j;
        }
    }
    Console.WriteLine();
}
int minSumLine = 0;
int sumLine = SumLineElements(matrix, 0);
for (int i = 1; i < matrix.GetLength(0); i++)
{
    int tempSumLine = SumLineElements(matrix, i);
    if (sumLine > tempSumLine)
    {
        sumLine = tempSumLine;
        minSumLine = i;
    }
}
int SumLineElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}

Console.WriteLine($"\n{minSumLine + 1} - строкa с наименьшей суммой ({sumLine}) элементов ");
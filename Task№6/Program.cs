// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
void PrintArray(int[,] matr)
{


    for (int i = 0;  i< matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}
void Sum (int [,] matr)
{
    for (int i = 0; i <  matr.GetLength(0); i++)
    {
        double sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum = sum +  matr [i,j];
        }
        Console.WriteLine($"Среднее арифместическое значение строки {i+1} равено:   {sum/( matr.GetLength(1))}");
    }
}



Console.WriteLine("Количество строк: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Количество столбцов: ");
int n = int.Parse(Console.ReadLine() ?? "0");

int[,] matrix = new int[m, n];
FillArray(matrix);
Console.WriteLine("Массив: ");
PrintArray(matrix);
Sum(matrix);


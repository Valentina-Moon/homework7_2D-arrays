//Показать двумерный массив размером m×n заполненный вещественными числами.

void FillArray(double[,] matr, int m , int n)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().NextDouble() * 100;
            Console.Write($"{matr[i, j]}\t");
        }
    }
}

void PrintArray(double[,] matr, int m, int n)
{


    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Количество строк: ");
 int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Количество столбцов: ");
 int n =  int.Parse(Console.ReadLine() ?? "0");


double[,] matrix = new double [m, n];


FillArray(matrix, m, n);
PrintArray(matrix, m, n);

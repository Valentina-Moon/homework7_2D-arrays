//В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
Console.Write("Введите количество строк m = ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов n = ");
int n = int.Parse(Console.ReadLine() ?? "0");

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ReplaceElements(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) matr[i, j] *= matr[i, j];
        }
   }
}

int[,] matrix = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(1, 10);
    }
}
Console.WriteLine("Изначальный массив: ");
PrintArray(matrix);
Console.WriteLine("Массив c заменинными элементы, у которых оба индекса чётные на их квадраты: ");
ReplaceElements(matrix);
PrintArray(matrix);
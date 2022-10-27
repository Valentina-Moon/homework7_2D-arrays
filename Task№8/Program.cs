// В прямоугольной матрице найти строку с наименьшей суммой элементов.

Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine()?? "0");
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine()?? "0");
int[,] matrix = new int[m, n];

if(m == n)
{
    Console.WriteLine("Прямоугольная матрица — это матрица, у которой число строк не равно числу столбцов! Введите заново!");
    return;
}
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
}
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}  ");
        }
        Console.WriteLine();
    }
}
int SumMin(int[,] matr)
{
    int sum = 0;
    int minSum = 0;
    int minNum = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == 0) 
            {
                sum += matr[i, j];
                minSum += matr[i, j]; 
            }
            else sum += matr[i, j]; 
        }
        if (sum < minSum)
        {
            minSum = sum;
            minNum = i;
        }
        sum = 0;
    }
    return minNum;
}

Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
Console.WriteLine($"Номер строки с наименшим элементом: {SumMin(matrix)}");
Console.WriteLine();
//Задать двумерный массив следующим правилом: Aₘₙ = m+n
void FillArray(int[,] Amatr)
{
    for (int m = 0; m < Amatr.GetLength(0); m++)
    {
        for (int n = 0; n < Amatr.GetLength(1); n++)
        {
            Amatr[m, n] = m + n;
        }


    }
}

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


Console.WriteLine("Количество строк: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Количество столбцов: ");
int n = int.Parse(Console.ReadLine() ?? "0");

int[,] matrix = new int[m, n];
FillArray(matrix);
Console.WriteLine("Двумерный массив заполненный по следующим правилом  A[mn] = m+n: ");
PrintArray(matrix);



















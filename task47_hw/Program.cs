// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
int ReadNumber (string messenge)
{
    Console.WriteLine(messenge);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] GetMatrix(int rowsCount, int columsCount, int leftRange = -10, int rightRange = 10)
{
    double[,] matrix = new double[rowsCount, columsCount];
    Random rand = new Random();
   for(int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rand.NextDouble()*(rightRange -leftRange)+rightRange;
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}\t ");
        }
         Console.WriteLine();
    }
}
int m = ReadNumber("Ведите количество строк");
int n = ReadNumber("Ведите количество столбцов");
double[,] matr = GetMatrix(m,n);
PrintMatrix(matr);
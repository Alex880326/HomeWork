// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int m, int n)
{
    int[,] matrix = new int [m, n];
    Random rand = new Random();
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            matrix[i,j] = rand.Next(new Random().Next(0,10));
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i,j] + "\t");
        }
        System.Console.WriteLine();
    }
}

double[] Mean(int[,] matrix, int n)
{
 double[] z = new double[n];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double num = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            num = (num + matrix[i, j]);
        }
        num = num / n;
        z[j] = Math.Round(num,2);
    }
    return z;
}

int m = ReadInt("Введите количетсво строк матрицы: ");
int n = ReadInt("Введите количество столбцов матрицы: ");
var myMatrix = GenerateMatrix(m, n);
double[] z =  Mean(myMatrix, n);
PrintMatrix(myMatrix);
System.Console.WriteLine("Среднее арифметическое каждого столбца:");
System.Console.Write(string.Join("\t",(z)));  
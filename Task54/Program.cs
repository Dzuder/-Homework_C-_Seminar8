using static System.Console;
Clear();

// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
Random rnd = new Random();
WriteLine("Введите размер двумерного массива через пробел: ");
int[] parameters = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);
int[,] array = new int[parameters[0], parameters[1]];

GetMatrixArray(array, parameters[0], parameters[1]);
PrintMatrixArray(array);
ArrangeRowToMin(array);
WriteLine("--------------------------------------------\n");
PrintMatrixArray(array);




void GetMatrixArray(int[,] arr, int row, int column)
{
    for (int i = 0; i <row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = rnd.Next(1, 99);
        }
    }
}

void PrintMatrixArray(int[,] arr1)
{
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            Write($"{arr1[i, j],4} ");
        }
        WriteLine("\n");
    }
}

void ArrangeRowToMin(int[,] arr2)
{
    int temp;
    for (int i = 0; i < arr2.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            for (int h = j + 1; h < arr2.GetLength(1); h++)
            {
                if (arr2[i, j] > arr2[i, h])
                {
                    temp = arr2[i, j];
                    arr2[i,j] = arr2[i,h];
                    arr2[i,h] = temp;
                }
            }
        }
    }
}
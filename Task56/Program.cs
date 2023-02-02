using static System.Console;
Clear();

// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.


Random rnd = new Random();
WriteLine("Введите размер двумерного массива где количество строк отличное от количества столбцов через пробел: ");
int[] parameters = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);
int[,] array = new int[parameters[0], parameters[1]];

GetMatrixArray(array, parameters[0], parameters[1]);
PrintMatrixArray(array);

WriteLine($"Массив из сумм элементов строк- [{String.Join(",", SumElementsRowArray(array))}]");

WriteLine("--------------------------------------------\n");
SearchRowMinSumElements(SumElementsRowArray(array));




void GetMatrixArray(int[,] arr, int row, int column)
{
    for (int i = 0; i < row; i++)
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

int[] SumElementsRowArray(int[,] arr2)
{
    int[] resultArray = new int[arr2.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < arr2.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            sum += arr2[i, j];
        }
        resultArray[i] = sum;
    }
    return resultArray;
}

void SearchRowMinSumElements(int[] arr3)
{
    int minValue = arr3[0];
    int rowMinSumElement = 0;
    for (int i = 0; i < arr3.Length; i++)
    
        {
            if (arr3[i] < minValue)
            {
                minValue = arr3[i];
                rowMinSumElement = i;
            }
        
        }
    
    WriteLine($"Номер строки с наименьшей суммой элементов: {rowMinSumElement + 1}.");
    WriteLine();

}

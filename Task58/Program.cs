using static System.Console;
Clear();
//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


Random rnd = new Random();
WriteLine("Введите размер первой матрицы через пробел: ");
int[] sizeMatrix1 = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);
int[,] array1 = new int[sizeMatrix1[0], sizeMatrix1[1]];

WriteLine("Введите размер второй матрицы через пробел: ");
int[] sizeMatrix2 = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);
int[,] array2 = new int[sizeMatrix2[0], sizeMatrix2[1]];



if(sizeMatrix1[1] == sizeMatrix2[0]){
GetMatrixArray(array1);
GetMatrixArray(array2);

PrintMatrixArray(array1);
WriteLine("----------------------------");
PrintMatrixArray(array2);
WriteLine("---------------------------------");

PrintMatrixArray(ProductMatrix(array1, array2));
}
else WriteLine("Умножать матрицы можно только тогда,\n когда количество столбцов первой матрицы равно количеству строк второй!!!");
    




void GetMatrixArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(1, 10);
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
        WriteLine();
    }
}


int[,] ProductMatrix(int[,] arr3, int[,] inArray)
{
    int[,] resultMatrix = new int[arr3.GetLength(0), inArray.GetLength(1)];
   
    
        if (arr3.GetLength(1) == inArray.GetLength(0))
        {
            for (int i = 0; i < arr3.GetLength(0); i++)
            {
                for (int j = 0; j < inArray.GetLength(1); j++)
                {
                    for (int m = 0; m < inArray.GetLength(0); m++)
                    {
                        {
                            resultMatrix[i, j] += arr3[i, m] * inArray[m, j] ;
                        }
                    }
                }
            }
        }    
    
   
return resultMatrix;
}

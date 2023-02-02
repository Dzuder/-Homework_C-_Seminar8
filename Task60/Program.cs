using static System.Console;
Clear();
//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


WriteLine("Введите размерность трехмерного массива через пробел: ");
int[] parameters = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);
int[,,] array = new int[parameters[0], parameters[1], parameters[2]];
int elementsRange = 99 - 9; //по условию задачи.
if (elementsRange < parameters[0] * parameters[1] * parameters[2]) WriteLine(@"Количество чисел в диапазоне не может быть меньше количества элементов в массиве!!!
По условиям задачи диапазон значений элементов- [10, 99].
");
else{

GetThreeDimensilonalArray(array);
Print(array);
}

void GetThreeDimensilonalArray(int[,,] arr)
{
    Random rnd = new Random();


    int[] numbArray = new int[arr.GetLength(0) * arr.GetLength(1) * arr.GetLength(2)];

    for (int m = 0; m < numbArray.Length; m++) numbArray[m] = rnd.Next(10, 100);



    int maxNumb = numbArray[0];
    for (int m = 1; m < numbArray.Length; m++)
    {

        if (numbArray[m] > maxNumb) maxNumb = numbArray[m];
    }


    for (int l = 0; l < numbArray.Length; l++)
    {
        for (int h = l + 1; h < numbArray.Length - 1; h++)
        {
            if (numbArray[l] == numbArray[h])
            {
                maxNumb++;
                numbArray[h] = maxNumb;
            }
        }
    }




    int n = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2) - 1; k++)
            {
                arr[i, j, k] = rnd.Next(10, 100);
                arr[i, j, (k + 1)] = rnd.Next(10, 100);
                if (arr[i, j, k] == arr[i, j, k + 1])
                {
                    arr[i, j, k] = numbArray[n];
                    n++;
                }



            }
        }
    }
}


void Print(int[,,] arr2)
{
    for (int i = 0; i < arr2.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            for (int k = 0; k < arr2.GetLength(2); k++)
            {
                Write($"{arr2[i, j, k]}-({i}, {j}, {k})    ");
            }
            WriteLine("");
        }
    }
}
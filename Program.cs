/* Задача 50. Напишите программу, которая на вход принимает позицию элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
5 -> 9
2 -> 7
9 -> 4

индексы:
[0][1][2][3]
1 4 7 2
[4][5][6][7]
5 9 2 3
[8][9][10][11]
8 4 2 4
*/

Console.Clear();
int[,] generateTwodimensionalArray(int height, int width, int randomStart, int randomEnd)
{
    int[,] twodimensionalArray = new int[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            twodimensionalArray[i, j] = new Random().Next(randomStart, randomEnd + 1);
        }
    }
    return twodimensionalArray;
}

void print2DArray(int[,] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write((arrayToPrint[i, j]) + "\t");
        }
        Console.WriteLine();
    }
}

void findElementInArray(int[,] generateArray, int position)
{
    if (position > generateArray.GetLength(1) * generateArray.GetLength(0))
    {
        Console.WriteLine($" чиста с индексом {position} в массиве нет");
    }
    else
    {
        if (position < generateArray.GetLength(1) * generateArray.GetLength(0))
        {
            int row = (position / generateArray.GetLength(1));
            int column = (position % generateArray.GetLength(1));
            Console.WriteLine($"числом с индексом {position} является {generateArray[row,column]}");
        }
    }
}

Console.Write("Введите позицию элемента: ");
int position = Convert.ToInt32(Console.ReadLine());
int[,] generateArray = generateTwodimensionalArray(4, 4, 0, 10);
print2DArray(generateArray);
findElementInArray(generateArray, position);

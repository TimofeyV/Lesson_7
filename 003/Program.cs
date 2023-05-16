// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateArray(string message1, string message2) // Создание массива + вывод сообщений
{
    Console.Write(message1);
    int lines = Convert.ToInt32(Console.ReadLine());
    Console.Write(message2);
    int colums = Convert.ToInt32(Console.ReadLine());
    int[,] arr = new int[lines, colums];
    return arr;
}

void FillArray(int[,] arr) // Заполнение массива
{
    int count = 1;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {   
            //Можно сделать заполнение случайными числами, для этого строку ниже разкоментить, остальное закоментировать
            //arr[i, j] = new Random().Next(-10,10);
            Console.Write($"Введите значение для элемента {count}: ");
            count++;
            int temp = Convert.ToInt32(Console.ReadLine());
            arr[i,j] = temp;
        }
    }
}

void PrintArray(int[,] arr) // Вывод массива в терминал
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FindAvg(int[,] arr) // Нахождение среднего арифметического в каждом столбце
{
    double avg = 0;
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            avg += Convert.ToDouble(arr[j, i]);
        }

        avg = Math.Round((avg / arr.GetLength(0)), 2);

        Console.Write($"{avg}");
        if ( i < arr.GetLength(1) - 1) Console.Write("; "); // Сделано, чтобы печать была, как и в задании
        else Console.Write("."); // на последнем элементе, который будет выведен, ставится точка(.)

        avg = 0; 
    }
}

Console.WriteLine("Данная программа считает среднее арифмитическое в столбцах двумерного массива");
int [,] arr = CreateArray("Введите количество линий: ", "Введите количество столбцов: ");
FillArray(arr);
PrintArray(arr);
FindAvg(arr);

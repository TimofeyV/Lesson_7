// Задача 50. Напишите программу, 
// которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

double[,] CreateArray(string message1, string message2) // Создание массива + вывод сообщений
{
    Console.Write(message1);
    int lines = Convert.ToInt32(Console.ReadLine());
    Console.Write(message2);
    int colums = Convert.ToInt32(Console.ReadLine());
    double[,] arr = new double[lines, colums];
    return arr;
}

void FillArray(double[,] arr) // Заполнение массива
{
    int count = 1;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {   
            //Можно сделать заполнение случайными числами, для этого строку ниже разкоментить, остальное закоментировать
            //arr[i, j] = Math.Round((new Random().Next(-10,10) + new Random().NextDouble()), 1);
            Console.Write($"Введите значение для элемента {count}: ");
            count++;
            double temp = Convert.ToDouble(Console.ReadLine());
            arr[i,j] = temp;
        }
    }
}

void PrintArray(double[,] arr) // Вывод массива в терминал
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

void FindNumber(double[,] arr) // Возвращает элемент c нужной позицией(индекс + 1)
{   
    Console.Write("Введите позицию элемент, который требуется найти в массиве: ");
    int position = Convert.ToInt32(Console.ReadLine());
    int count = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            count++;
            if (count == position) Console.WriteLine($"Элемент в массиве, с позицией {position} = {arr[i,j]} ");
        }
    }

    if (count < position) Console.WriteLine($"Элемент в массиве, с позицией {position} нет");
    Console.WriteLine("--------------------------------------");
}

Console.WriteLine("Данная программа найдёт число в массиве по его позиции");
double [,] arr = CreateArray("Введите количество линий: ", "Введите количество столбцов: ");
FillArray(arr);
PrintArray(arr);
FindNumber(arr);
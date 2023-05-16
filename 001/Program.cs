// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateArray(string message1, string message2) // Создание массива + вывод сообщений
{
    Console.Write(message1);
    int lines = Convert.ToInt32(Console.ReadLine());
    Console.Write(message2);
    int colums = Convert.ToInt32(Console.ReadLine());
    double[,] arr = new double[lines, colums];
    return arr;
}

void FillArray(double[,] arr) // Заполнение массива случайными вещественными числами
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Math.Round((new Random().Next(-10,10) + new Random().NextDouble()), 1);
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

Console.WriteLine("Данная программа создаст массив, заполненный случайными числами");
double [,] arr = CreateArray("Введите количество линий: ", "Введите количество столбцов: ");
FillArray(arr);
PrintArray(arr);



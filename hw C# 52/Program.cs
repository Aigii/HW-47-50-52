//  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.WriteLine(" введите количество строк...");
int l = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" ввести количество столбцов...");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] array = new int[l, c];
FillArrayRandomArray(array);
PrintArray(array);
Summa(array);
void FillArrayRandomArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10,10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Summa(int[,] array)
{
    for(int j =0; j<array.GetLength(1); j++) 
{
    double mean = 0;
    for(int i =0; i<array.GetLength(0); i++) 
    {
        mean = (mean + array[i,j]);
    }
    mean = mean/c;
    Console.Write(mean + "; ");
}
    Console.WriteLine();
}

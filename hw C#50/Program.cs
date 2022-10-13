// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine(" введите номер  строки..."); 
int l= Convert.ToInt32(Console.ReadLine());       
Console.WriteLine(" ввести номер  столбца..."); 
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("______________________");
int[,] array = new int[9,9];
FillArrayRandomArray(array);
PrintArray(array);

if (l>array.GetLength(0) && c>array.GetLength(1))
{
    Console.WriteLine("Такого элемента нет ");
    
}
else 
{
    Console.WriteLine($" значение элемента строки { l} и столбца {c},  равно: {array[l, c]}");
}
void FillArrayRandomArray(int[,] array)
 {
     for (int i = 0; i < array.GetLength(0); i++)
    {
         for (int j = 0; j < array.GetLength(1); j++)
         {
            array[i, j] = Convert.ToInt32(new Random().Next(1,100));
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


// if(line>array.GetLength(0)|| column>array.GetLength(1))
// { 
//     System.Console.WriteLine(" такого элемента НЕТ...");
// }
// else {
//     System.Console.WriteLine($" значение элемента строки и столбца { line} , {column} равно {array[line-1, column-1]}");
// }
// void FillArrayRandomArray(int [ , ] array)
// {
//     for(int i =0; i<array.GetLength(0); i++)                ///заполняем строки
//     {
//         for(int j =0; j<array.GetLength(1); j++)            ///заполнем столбцы
//         {
//             array[i,j] = new Random().Next(-100,100)/10;   ///рандомное заполнение по формуле
//         }
//     }
// }
// void PrintArray(int[ , ] array){                                         /// печать
//     for(int i=0; i<array.GetLength(0); i++)                                 ///бежим по строкам
//     {
//         for(int j=0; j<array.GetLength(1); j++)                             ///бежим по столбцам
//         {
//             System.Console.Write(array [i,j]+"\t");                        ///вывод массива \t это для вывода табличкой
//         }
//         System.Console.WriteLine();
//     }
// }
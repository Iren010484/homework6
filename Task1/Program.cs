﻿/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

int ReadInt(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine()); 
    return number;
}

int[] GetBinArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = Convert.ToInt32(Console.ReadLine());
    }
    return result;
}

bool ParityCheck(int number)
{
if (number > 0)
    {
        return true;
    }
    return false;
}

int m = ReadInt("Введите количество чисел");
Console.WriteLine($"Введите {m} чисел");
int[] array = GetBinArray(m);
Console.Write($"[{String.Join(", ", array)}]");
Console.WriteLine();
int counter = 0;
for (int i=0; i < m ; i++)
    {
        if (ParityCheck(array[i])) counter++;
    }
Console.WriteLine($"Количество чисел больших 0 равно {counter}");
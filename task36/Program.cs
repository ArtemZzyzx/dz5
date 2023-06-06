﻿/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] array = new int[4];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100);
}
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 1)
    {
        sum += array[i];
    }
}
Console.WriteLine($"Сумма нечетных чисел массива [{String.Join("; ", array)}] равна {sum}");
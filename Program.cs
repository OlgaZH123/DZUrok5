//  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

/*int [] startArray = GetArray(6, 100, 999);
Console.WriteLine(String.Join(",", startArray));
Console.WriteLine($"Количество четных элементов в массиве = {GetCount(startArray)}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i=0; i<size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int GetCount (int[] array)
{
    int count = 0;
    foreach (var item in array)
    {
        if (item % 2 == 0) count++;
    }
        
        return count;
}*/




// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.

/*int [] startArray = GetArray(6, 0, 999);
Console.WriteLine(String.Join(",", startArray));
Console.WriteLine($"Сумма элементов на нечетных позициях = {GetSum(startArray)}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i=0; i<size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int GetSum (int[] array)
{
    int sum = 0;
    for (int i=0; i<array.Length; i++)
    {
        if (i % 2 == 1) sum += array[i];
    }
        
        return sum;
}*/




// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

int [] startArray = GetArray(10, 0, 5);
Console.WriteLine(String.Join(" ", startArray));

Console.WriteLine(String.Join(" ", ResultArray (startArray)));

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int ResultArray (int[] array)
{
    int size = array.Length / 2;
    if (array.Length % 2 == 1) size++;
    int[] result = new int[size];
    for (int i = 0; i < array.Length / 2; i++)
    {
        result[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 == 1) result[size - 1] = array[array.Length / 2];
    return result;
}
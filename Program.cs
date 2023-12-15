// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементов массива.

double[] array = new double[10];
for (int i = 0; i < array.Length; i++)
{
System.Console.WriteLine("Введите числа массива");
array[i] = Convert.ToInt32(Console.ReadLine());    
}
for (int i = 0; i < array.Length; i++)
{
    int min = 0;
    if (array[i] > array[min])
    {
    min = i;
    }
}
System.Console.WriteLine($"Минимальное значение массива = {min}");
for (int i = 0; i < array.Length; i++)
{
    int max = 0;
    if (array[i] > array[max])
    {
    max = i;
    }
}
System.Console.WriteLine($"Максимальное значение массива = {max}");

int diff = array[max] – array[min];
Console.WriteLine($"Разница = {diff}");

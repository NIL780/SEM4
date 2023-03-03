
Console.Clear();
//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.WriteLine("Создать массив из 8 элементов");
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(n + 1);
    Console.Write(array[i] + "; ");
}
Console.WriteLine();

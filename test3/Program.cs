// Задача 29.Напишите программу, которая задает массив
// из 8 элементов и выводит их на экран

Console.WriteLine("Программа задает массив из 8 элементов");
Console.WriteLine(" ");

int[]CreateArray(int size);
{
    int[] array = new int[size];
    for(int i = 0; i < array.length; i++)
    {
    return array;         
    }
}
void PrintArray(int[]array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        Console.WriteLine(array[1] + ",");
    }
    Console.WriteLine(array[i] + ",");
}
Console.WriteLine("Сгенерированный массив:");
PrintArray(CreateArray(8));


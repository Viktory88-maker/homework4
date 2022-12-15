// Задача 25. Напишите цикл, который принимает на вход два числа 
//(А И В) и возводит число А в натуральную степень.

Console.WriteLine("Введите число а = ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число b = ");
int b = int.Parse(Console.ReadLine()!);

int Pow(int numA, int numB);
{
    int result = 1;
    for(int i = 1; i <= numB; i++)
    {
        result *= numA;
    }
    return result;
}
Console.WriteLine ($"Результатом будет число: {Pow(a,b)}");


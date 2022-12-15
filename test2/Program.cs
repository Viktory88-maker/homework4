// Задача 27. Напишите программу, которая принимает на вход число и выдает
// cумма цифр в числе

Console.WriteLine("Введите число ");
int num = int.Parse(Console.ReadLine()!);
int sum = 0;

while (num != 0)
{
    sum += num%10;
    num /= 10;

}
Console.WriteLine ($"Сумма цифр в числе:{sum}");



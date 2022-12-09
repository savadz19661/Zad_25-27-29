// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();
Console.Write ("Введите число: ");
int limit = int.Parse(Console.ReadLine ());

Console.WriteLine ($"Сумма цифр числа {limit} равна {GetSum(limit)}");
int GetSum (int limit)
{
    int sum = 0;
    while ( limit > 0)
    {
         sum += limit % 10; limit /= 10;
    } 

    return sum;
}
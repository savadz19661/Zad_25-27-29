//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Clear();
Console.Write ("Введите число A = ");
double x = double.Parse(Console.ReadLine());

Console.Write ("Введите число B = ");
double stepen = double.Parse(Console.ReadLine());

double i = Math.Pow(x, stepen);
Console.Write($"Число {x} в степени {stepen} равно = " + Math.Pow(x, stepen) );

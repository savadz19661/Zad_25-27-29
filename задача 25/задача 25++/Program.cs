//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Clear();
Console.Write ("Введите число A =  ");
int num = int.Parse(Console.ReadLine());

Console.Write("Введите число B =  ");
int n = int.Parse(Console.ReadLine());

int num_n=1;
for(int i=0; i<n; i++)
{
  num_n*=num;
}
 Console.Write($"Число {num} в степени {n} равно = {num_n} ");   
return num_n;
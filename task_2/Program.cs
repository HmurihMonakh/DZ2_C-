﻿//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
Console.WriteLine("Введите число: ");
int numbers = Convert.ToInt32(Console.ReadLine());
string Number = Convert.ToInt32(numbers);
if(numbers > 99)
{
    Console.WriteLine((numbers / 100) % 10);
    Console.WriteLine("Третья цифра => " + Number[2]);
}
else
{
    Console.WriteLine(" => Цифры нет");
}
*/

Console.WriteLine("Введите число: ");
int numbers = int.Parse(Console.ReadLine()!);

if(numbers > 99 && numbers < 1000)
{
    Console.WriteLine((numbers % 100) % 10); 
}
if(numbers > 999 && numbers < 10000)
{
    Console.WriteLine((numbers % 100) / 10); 
}
if(numbers > 9999 && numbers < 100000)
{
    Console.WriteLine((numbers % 1000) / 100); 
}

if(numbers < 100)
{
    Console.WriteLine($"Цифры третьей нет");
}


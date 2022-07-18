//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число: ");
int numbers = Convert.ToInt32(Console.ReadLine());

string Number = Convert.ToString(numbers);

Console.WriteLine("Второе число => " + Number[1]);
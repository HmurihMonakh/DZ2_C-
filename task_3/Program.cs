//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введи цыфру дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 6 || day == 7) 

{
    Console.WriteLine("(это выходной) <= да");
}

else if (day < 1 || day > 7) 

{
    Console.WriteLine("такого дня недели нет");
}

else Console.WriteLine("(не выходной) <= нет");



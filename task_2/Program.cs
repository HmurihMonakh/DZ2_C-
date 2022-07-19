//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число: ");
int numbers = Convert.ToInt32(Console.ReadLine());
string Number = Convert.ToString(numbers);
if(numbers > 99)
{
    Console.WriteLine((numbers / 100) % 10);
    Console.WriteLine("Третья цифра => " + Number[2]);
}
else
{
    Console.WriteLine(" => Цифры нет");
}

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (Максимум 100000)
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()!);

if (number <= 99)
{
    Console.WriteLine("Третьей цифры нет");
}
else if (number > 99  && number <= 999)
{
    int num1 = number % 10;
    Console.WriteLine($"Третья цифра от {number} = {num1}");
}
else if (number > 999  && number <= 9999)// 1234 % 100 = 34 / 10 = 3
{
    int num2 = number % 100 / 10;
    Console.WriteLine($"Третья цифра от {number} = {num2}");
}
else if (number > 9999  && number <= 99999)// 12345 % 1000 = 345 / 100 = 3
{
    int num3 = number % 1000 / 100;
    Console.WriteLine($"Третья цифра от {number} = {num3}");
}
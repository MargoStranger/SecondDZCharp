//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. (Проверка на трехзначность при вводе пользователем)
//456 -> 5 
//782 -> 8
//918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine()!);

while(number < 100 || number > 99999)
{
    Console.WriteLine("Вы ввели не  трехзначное, повторите ввод трехзначного числа: ");
    number = Convert.ToInt32(Console.ReadLine()!);
  //  Console.WriteLine($"Ваше число {number}?");
}

int b = number%100/10;

Console.WriteLine($"Вторая цифра от {number} = {b}");

//Сделано с проверкойна дурочка

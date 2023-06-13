//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.(использовать И и ИЛИ)
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите день недели цифрой: ");
int Date = Convert.ToInt32(Console.ReadLine()!);

if (Date < 1 || Date > 7)
{
    Console.WriteLine("Такого дня нет");
}
else if(Date >= 1  && Date <= 5)
{
    Console.WriteLine("Будний день");
}
else if(Date >= 6  && Date <= 7)
{
    Console.WriteLine("Выходной день");
}
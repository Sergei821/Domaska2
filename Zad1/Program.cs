﻿//Задача 1: Напишите программу, которая принимает на вход трёхзначное число и 
//на выходе показывает вторую цифру этого числа. Не использовать строки для расчета 
//(решать только при помощи операций % и /).

//456 -> 5
//782 -> 8
//918 -> 1

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int number = Prompt("введите трёхзначное число > ");
if (number < 100 || number >= 1000)
{
    Console.WriteLine("вы ввели не трёхзначное число, пожалуйста повторите ввод");
    return;
}
Console.WriteLine($"введите число '{number}'");
int secondRank = number /10 %10;
Console.WriteLine($"вторая цифра '{secondRank}'");

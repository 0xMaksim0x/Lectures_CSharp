﻿//Напишите программу, которая выводит
//случайное число из отрезка [10, 99] и показывает
//наибольшую цифру числа.

//78 -> 8
//12-> 2
//85 -> 8

int num = new Random().Next(10,100);
Console.WriteLine(num);
// 94
int num1 = num / 10 ; // 94 / 10 = 9
int num2 = num % 10 ; // 94 % 10 = 4

if(num1 > num2 )
{
    Console.WriteLine($"max = {num1}");
}
else
{
    Console.WriteLine(" max = " + num2);
}

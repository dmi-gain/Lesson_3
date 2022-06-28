/*
Задача 1: Напишите программу, которая принимает на
вход пятизначное число и проверяет, является ли оно
палиндромом.

14212 -> нет
23432 -> да
12821 -> да

*/

int Prompt(string message) 
{
    Console.WriteLine(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}

int number = Prompt("Введите пятизначное число");

int a = number % 10; 
int b = number % 100 / 10;
int c = number / 100 % 10;
int d = number / 1000 % 10;
int e = (number / 10000);

string sum = ($"{a}{b}{c}{d}{e}");

int numberBack = int.Parse(sum);

if (number == numberBack)
{
    Console.WriteLine($"Число {number} является палиндромом");
}
else
    Console.WriteLine($"Число {number} не является палиндромом");





/*
Задача 3: Напишите программу, которая принимает на
вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27.
5 -> 1, 8, 27, 64, 125

*/

int Prompt(string message) 
{
    Console.WriteLine(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}
int number = Prompt("Введите число N");
int count = 0;

while (count < number)
{
    count++;
    Console.WriteLine(count*count*count);
}

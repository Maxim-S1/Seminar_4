// Задача 28: Напишите программу, которая принимает на вход число N и 
// выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int res = 1;

for (int i = 1; i <= N; i++)
{
    res = res * i;
}
Console.WriteLine($"Произведение чисел от 1 до N = {res}");
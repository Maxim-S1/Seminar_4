//Напишите программу , которая принимает вн ввод число (А) и выдает сумму от 1 до А.
Console.WriteLine("Введите число А");
int A = Convert.ToInt32(Console.ReadLine());

int sum = 0;

for (int i = 1; i <= A; i++)
{
    sum = sum + i;
    // sum += i;
}
Console.WriteLine($"Сумма чисел от 1 до А = {sum}");
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12



Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int tempNumber = number;
int result = 0;

while (tempNumber > 0)
{
    result += tempNumber % 10;
    tempNumber = tempNumber / 10;
}
Console.WriteLine($"Сумма цифр числа {number} = {result}");
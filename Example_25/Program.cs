
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int tempNumber = firstNumber;

for (int i = 1; i < secondNumber; i++) tempNumber = tempNumber * firstNumber;
Console.WriteLine($"Число {firstNumber} в степени {secondNumber} = {tempNumber}");


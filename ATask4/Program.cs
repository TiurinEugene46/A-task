// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите три числа: ");
int number_1 = int.Parse(Console.ReadLine());
int number_2 = int.Parse(Console.ReadLine());
int number_3 = int.Parse(Console.ReadLine());

int max = Math.Max(number_1, Math.Max(number_2, number_3));

Console.WriteLine($"{max} максимальное число");
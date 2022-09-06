// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Вводные числа 
Console.WriteLine("Введите два числа: ");
int number_1 = int.Parse(Console.ReadLine());
int number_2 = int.Parse(Console.ReadLine());

if(number_1 > number_2)
{
    Console.WriteLine($"{number_1} больше {number_2}");
}
if(number_1 < number_2)
{
    Console.WriteLine($"{number_1} меньше {number_2}");
}
if(number_1 == number_2)
{
    Console.WriteLine($"{number_1} равно {number_2}");
}
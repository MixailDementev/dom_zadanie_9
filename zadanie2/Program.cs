// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Write("Введите число1: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите число2: ");
int number2 = int.Parse(Console.ReadLine());

int NumbersSum(int number1, int number2)
{
    int result=0;
    for(int i=number1; i<=number2;i++) result+=i;
    return result;
}
System.Console.WriteLine($"Сумма элементов равна = {NumbersSum(number1,number2)}"); 
// Задача 64: Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""


Console.Write("Введите число1: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите число2: ");
int number2 = int.Parse(Console.ReadLine());

string NumbersRec(int number1, int number2)
{
    if (number1 <= number2) return $"{number1} " + NumbersRec(number1 + 1, number2);
    else return String.Empty;
}
System.Console.WriteLine(NumbersRec(number1,number2));  
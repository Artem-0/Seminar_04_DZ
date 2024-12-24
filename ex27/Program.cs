// Задача 27. Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.

int ReadIntAbs(string text)
{
    System.Console.WriteLine(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

int SumNumbers(int value)
{
    int sum = 0;
    while (value > 0)
    {
        sum = sum + value % 10;
        value = value / 10;
    }
    return sum;
}

int number = ReadIntAbs("Введите число: ");
System.Console.WriteLine(SumNumbers(number));
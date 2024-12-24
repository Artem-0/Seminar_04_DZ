// Задача 25. Напишите программу, которая принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B.

void WriteText(string text)
{
    System.Console.Write(text);
}

int ReadIntAbs(string text)
{
    System.Console.Write(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}


int NumberPower(int A, int B)
{
    int result = 1;
    for (int i = 1; i <= B; i++)
    {
        result = result * A;
    }
    return result;
}

int A = ReadIntAbs("Введите число A: ");
int B = ReadIntAbs("Введите число B: ");
WriteText("Число A в степени B равно: ");
System.Console.WriteLine(NumberPower(A, B));
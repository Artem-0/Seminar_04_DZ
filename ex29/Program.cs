// Задача 29. Напишите программу, которая создаёт массив заданной длины,
// заполняет его случайными числами заданного диапазона и выводит его на
// экран.

int ReadIntAbs(string text)
{
    System.Console.WriteLine(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}


void FillArray(int[] arrayToFill, int down, int up)
{
    Random rand = new Random();

    for (int i = 0; i < arrayToFill.Length; i++)
    {
        arrayToFill[i] = rand.Next(down, up);
    }
}

void PrintArray(int[] arrayForPrint)
{
    for (int i = 0; i < arrayForPrint.Length; i++)
    {
        System.Console.Write(arrayForPrint[i] + " ");
    }
}

int lengthArray = ReadIntAbs("Введите длину массива: ");
int downRand = ReadIntAbs("Введите Нижнюю границу генерации чисел массива: ");
int topRand = ReadIntAbs("Введите Верхнюю границу генерации чисел массива: ");

int[] array = new int[lengthArray];

FillArray(array, downRand, topRand);
PrintArray(array);
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3->A(m, n) = 9
// m = 3, n = 2->A(m, n) = 29

Console.Clear();
Console.Write("Введите число M: ");
int numberM = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int numberN = int.Parse(Console.ReadLine()!);


int result = AkkermanFunction(numberM, numberN);
Console.WriteLine(result);


int AkkermanFunction(int numberN, int numberM)
{
    if (numberN == 0)
    {
        return numberM + 1;
    }
    if (numberN != 0 && numberM == 0)
    {
        return AkkermanFunction(numberN - 1, 1);
    }
    if (numberN > 0 && numberM > 0)
    {
        return AkkermanFunction(numberN - 1, AkkermanFunction(numberN, numberM - 1));
    }
    return AkkermanFunction(numberN, numberM);
}

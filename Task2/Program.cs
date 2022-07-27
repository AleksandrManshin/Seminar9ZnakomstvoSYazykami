// Задача 65: Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.

void Zadacha65()
{
    Console.Write("Введите первое число промежутка: ");
    int numbM = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число промежутка: ");
    int numbN = Convert.ToInt32(Console.ReadLine());
    Recursion(numbM, numbN);

    void Recursion(int numbM, int numbN)
    {
        if (numbM > numbN) return;
        Console.Write(numbM + " ");
        numbM++;
        Recursion(numbM, numbN);
    }
}

Zadacha65();
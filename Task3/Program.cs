// Задача 67: Напишите программу, которая будет принимать
// на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

void Zadacha76()
{

    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int count = 0;

    Recursion(number, count);

    void Recursion(int number, int count)
    {
        if (number == 0)
        {
            Console.WriteLine(count);
            return;
        }
        count = count + number % 10;
        number = number / 10;

        Recursion(number, count);
    }

    // while(number != 0)
    // {
    //     count = count + number % 10;
    //     number = number / 10;
    // }
    //Console.WriteLine(count);
}

Zadacha76();
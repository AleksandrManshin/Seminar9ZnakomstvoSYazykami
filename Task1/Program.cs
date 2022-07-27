void Zadachd63()
{
    int number = 15;
    int count = 1;

    Recursion(count, number);

    void Recursion(int count, int number)
    {
        if (count > number) return;
        Console.WriteLine(count + " ");
        count++;
        Recursion(count, number);
    }

}

Zadachd63();
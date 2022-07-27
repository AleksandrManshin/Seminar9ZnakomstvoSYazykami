void Zadacha69()
{
    int a = 5;
    int b = 4;
    Recursion(a, b);

    void Recursion(int a, int b, int result = 1)
    {
        if (b == 0)
        {
            Console.WriteLine(result);
            return;
        }

        result *= a;
        b--;
        Recursion(a,b,result);

    }
}

Zadacha69();

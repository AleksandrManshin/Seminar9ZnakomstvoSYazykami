Random random = new Random();
int rowsFirst = random.Next(3,7);
int columnsFirst = random.Next(3,7);
int rowsSecond = columnsFirst;
int columnsSecond = random.Next(3,7);

int[,] arrayFirst = new int [rowsFirst, columnsFirst];
int[,] arraySecond = new int [rowsSecond, columnsSecond];
int[,] arrayResult = new int [rowsFirst, columnsSecond];

FillArray(arrayFirst);
FillArray(arraySecond);
PrintArray(arrayFirst);
Console.WriteLine();
PrintArray(arraySecond);
Console.WriteLine();

    for(int i = 0; i < rowsFirst; i++)
    {
        for(int j = 0; j < columnsSecond; j++)
        {
            for (int k = 0; k < rowsSecond; k++)
            {
                arrayResult[i, j] += arrayFirst[i, k] * arraySecond[k, j];
            }
        }
    }

PrintArray(arrayResult);


void FillArray(int [,] array)
{
    Random random = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array [i, j] = random.Next(1, 10);
        }
    }
}

void PrintArray(int [,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            Console.Write(array [i, j] + "\t");
        }
        Console.WriteLine();
    }

}
using System;

class ASS3
{
    static void Main()
    {
        int[,] matrix1 =
        {
            {1, 2},
            {3, 4}
        };

        int[,] matrix2 =
        {
            {5, 6},
            {7, 8}
        };

        int[,] result = new int[2, 2];

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        Console.WriteLine("Result Matrix:");

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(result[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
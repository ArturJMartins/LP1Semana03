using System;

namespace ArrayMult
{
    class Program
    {
        static void Main(string[] args)
        {

            float[,] matrixA = {
            { float.Parse(args[0]), float.Parse(args[1]) },
            { float.Parse(args[2]), float.Parse(args[3]) }
            };

            float[] matrixB = {
            float.Parse(args[4]),
            float.Parse(args[5])
            };

            float[] result = new float[2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                result[i] += matrixA[i, j] * matrixB[j];
                }
            }

            Console.WriteLine($"{result[0]}");
            Console.WriteLine($"{result[1]}");
        }
    }
}

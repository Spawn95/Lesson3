using System;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5, 5];
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(0); j++)
                    matrix[i, j] = i + j; ;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    System.Console.Write(matrix[i, j] + " ");
                }
                System.Console.WriteLine();
            }
            Console.WriteLine($"Введите число в интервале от -4 до 4");
            string W = Console.ReadLine();
            if (!int.TryParse(W, out var z))
            {
                Console.WriteLine("Некорректный ввод!");
                return;
            }
            if (z < -4 || z > 4)
            {
                Console.WriteLine("Номер указан не верно!");
                return;
            }
            int number = z ;
            var T = 5 - z;
            for (int i = 0, j = 0; i < T || j < T; i++, j++)
            {
                int w = z switch
                {
                    0 => matrix[i, j],
                    < 0 => matrix[i, j + number],
                     _=> matrix[i + number, j]
                };
                Console.Write(w + " ");
            }
        }
    }
}



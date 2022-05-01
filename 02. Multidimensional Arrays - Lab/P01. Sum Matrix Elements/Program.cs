﻿using System;
using System.Linq;

namespace P01._Sum_Matrix_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rows = input[0];
            int cols = input[1];    
            int[,] matrix = new int[rows, cols];    
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }

            }
            int sum = 0;
            for (int  row = 0;  row < matrix.GetLength(0);  row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    sum+=matrix[row, col];
                }
            }
            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);
        }
    }
}

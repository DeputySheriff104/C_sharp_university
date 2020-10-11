using System;

namespace Task1
{
    class Program
    {
        private static void Main(string[] args)
        {
            int[][] matrix = GetMatrix();
            OutputMatrix(matrix);
            Console.WriteLine($"Number of monotonic arrays: {CountMonotonicArrays(matrix)}");
        }

        private static int CountMonotonicArrays(int[][] matrix)
        {
            int numOfMonotonicArrays = 0;
            int matrixLength = matrix.GetUpperBound(0) + 1;
            for (var i = 0; i < matrixLength; i++)
            {
                if (IsIntArrayMonotonic(matrix[i]))
                {
                    numOfMonotonicArrays++;
                }
            }
            return numOfMonotonicArrays;
        }

        private static bool IsIntArrayMonotonic(int[] array)
        {
            bool isIncreasing = false;
            bool isDecreasing = false;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[i - 1])
                {
                    if (isDecreasing)
                    {
                        return false;
                    }

                    isIncreasing = true;
                }
                else
                {
                    if (array[i] < array[i - 1])
                    {
                        if (isIncreasing)
                        {
                            return false;
                        }

                        isDecreasing = true;
                    }
                }
            }

            return true;
        }

        private static void OutputMatrix(int[][] matrix)
        {
            for (var i = 0; i < matrix.Length; i++)
            {
                for (var j = 0; j < matrix.Length; j++)
                {
                    Console.Write($"{matrix[i][j]} ");
                }

                Console.WriteLine();
            }
        }

        private static int[][] GetMatrix()
        {
            Console.Write("Введите 0 для захардкоженной матрицы или 1 для ручного ввода матрицы: ");
            int num = int.Parse(Console.ReadLine());
            if (num == 0)
            {
                int[][] matrix =
                {
                    new[] {1, 2, 3, 4},
                    new[] {3, 2, 1, 4},
                    new[] {7, 6, 5, 4},
                    new[] {1, 0, 0, 1}
                };
                return matrix;
            }
            if (num == 1)
            {
                int[][] matrix = {
                    new[] {0, 0, 0, 0},
                    new[] {0, 0, 0, 0},
                    new[] {0, 0, 0, 0},
                    new[] {0, 0, 0, 0}
                };
                for (int i = 0; i < matrix.Length; i++)
                {
                    for (int j = 0; j < matrix[0].Length; j++)
                    {
                        matrix[i][j] = int.Parse(Console.ReadLine());
                    }
                }
                return matrix;
            }
            return null;
        }
    }
}
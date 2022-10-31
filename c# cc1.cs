using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] ar = new int[n, n];
            int a, b;
            ar = GetArray(n);

            for (a = 0; a < n; a++)
            {
                for (b = 0; b < n; b++)
                {
                    Console.Write(ar[a, b] + " ");
                }
                Console.WriteLine();
            }
        }
        public static int[,] GetArray(int p)
        {
            int[,] arr = new int[p, p];
            int i, j;
            for (i = 0; i < p; i++)
            {

                for (j = 0; j < p; j++)
                {
                    if (i == j)
                    {
                        arr[i, j] = 0;
                    }
                    else if (i < j)
                    {
                        arr[i, j] = 1;
                    }
                    else
                    {
                        arr[i, j] = -1;
                    }


                }
            }
            return arr;



        }
    }
}
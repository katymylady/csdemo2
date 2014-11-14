using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] a = { { 1, 2, 3 }, { 3, 4, 5 } };
            double[,] b = { { 3, 4, 2 }, { 5, 6, 1 } };
            double[,] at = transpose(a);

            Console.WriteLine("a.GetLength(0)=" + a.GetLength(0));
            Console.WriteLine("a.GetLength(1)=" + a.GetLength(1));
            printMatrix("a", a);
            printMatrix("b", b);
            printMatrix("at", at);
        }

        static void printMatrix(String name, double[,] x)
        {
            Console.WriteLine("==========" + name + "==============");
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    Console.Write(x[i,j]+" ");
                }
                Console.WriteLine();
            }
        }

        static double[,] transpose(double [,] x)
        {
            double[,] t = new double[x.GetLength(1), x.GetLength(0)];
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    t[j, i] = x[i, j];
                }
            }
            return t;
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication21
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] A = new double[10, 10];
            double maior, menor;

            //Gera a matriz
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    A[i, j] = (2 * i) + j;
                }
            }
            maior = A[0, 0];
            menor = A[0, 0];
            //Mostra a matriz gerada
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(A[j, j]);
                }
            }
            //Elementos da diagonal principal
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == j)
                    {
                        Console.Write("Diagonal principal:" + A[i, j]);
                    }
                }
            }
            //maior
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (A[i, j] > maior)
                    {
                        maior = A[i, j];
                    }
                }
            }
            //menor
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (menor < A[i, j])
                    {
                        menor = A[i, j];
                    }
                }
            }


            Console.ReadLine();
        }
    }
}

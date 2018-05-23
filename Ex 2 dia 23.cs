using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] A = new double[2, 3];
            double[,] B = new double[2, 3];
            double[,] C = new double[2, 3];
            double maior, menor;

            //Ler a matriz A
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Digite um elemento da matriz A:");
                    A[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }
            //Ler a matriz B
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Digite um elemento da matriz B:");
                    B[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }
            maior = A[0, 0];
            menor = B[0, 0];

            //Gerar a matriz C
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    C[i, j] = (3 * A[i, j]) + B[i, j];
                }
            }
            //Maior elemenro de A
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (maior > A[i, j])
                    {
                        maior = A[i, j];
                    }
                }
            }
            //Menor elemento de B
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (menor < B[i, j])
                    {
                        menor = B[i, j];
                    }
                }
            }
            //SAIDA
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Matriz C:" + C[i, j]);
                }
            }
            Console.WriteLine("Maior elemento de A: " + maior);
            Console.WriteLine("Menor elemento de B: " + menor);




            Console.ReadKey();
        }
    }
}

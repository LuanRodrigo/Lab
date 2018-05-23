using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication23
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] A = new double[3, 4];
            double somal = 0, somac = 0, maior, menor, somaM = 0, media, posi, posj, posi2, posj2;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("Digite um numero:");
                    A[i, j] = Convert.ToDouble(Console.ReadLine());
                    somaM = somaM + A[i, j];
                }
            }

            maior = A[2, 0];
            menor = A[0, 3];
            media = somaM / 12;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == 3)
                    {
                        somal = somal + A[i, j];
                    }
                    if (j == 4)
                    {
                        somac = somac + A[i, j];
                    }
                }
            }
            //maior elemento da egunda linha
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == 2)
                    {
                        if (maior > A[i, j])
                        {
                            maior = A[i, j];
                            posi = i;
                            posj = j;
                        }
                    }
                }
            }
            //menor elemento da ultima coluna
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 3)
                    {
                        if (menor < A[i, j])
                        {
                            menor = A[i, j];
                            posi2 = i;
                            posj2 = j;
                        }
                    }
                }
            }
            //SAIDA

            Console.WriteLine("Soma elementos ultima linha e primeira coluna: " + (somal + somac));
            Console.WriteLine("Maior elemento da egunda linha: " + maior + " sua localização: [" + posi + "," + posj + "]");
            Console.WriteLine("Menor elemento da ultima coluna: " + menor + " sua localização: [" + posi2 + "," + posj2 + "]");
            Console.WriteLine("Media dos elementos da matriz: " + media);
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (A[i, j] > media)
                    {
                        Console.WriteLine("Acima da media: " + A[i, j] + "localização: [" + i + "," + j"]");
                    }
                }
            }





            Console.ReadKey();
        }
    }
}

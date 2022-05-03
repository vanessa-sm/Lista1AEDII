//1) Ordene um vetor de 100 números inteiros gerados aleatoriamente.
using System;

namespace m1
{
    class Program
    {
        static void Main(string[] args)
        {
            //gera vetor aleatorio de 100 posicoes
            Random numAleatorio = new Random();
            int [] aleatorios = new int [100];

            for (int i = 0; i < 100; i++)
            {
                int valorInteiro = numAleatorio.Next(1,10001);
                aleatorios[i] = valorInteiro;
            
            }
                //for (int i = 0; i < 100; i++)
                //{
                //    Console.WriteLine(aleatorios[i]);
                //}

                //Ordena o vetor
                Array.Sort(aleatorios);
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(aleatorios[i]);
                }
                
            
        }
    }
}

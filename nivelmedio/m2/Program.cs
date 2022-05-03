//2) Crie dois vetores de 50 posições com valores inteiros aleatórios, ordene cada vetor individualmente,
//e combine os dois vetores gerando um novo  vetor de 100 posições, de forma  que esse novo vetor já seja criado ordenado.
using System;
using System.Linq;

namespace m2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numAleatorio = new Random();
            int [] vetor1 = new int[5];
            int [] vetor2 = new int[5];
            int [] vetor3 = new int[10];
             //int [] vetorcomposto;

            for (int i = 0; i < 5; i++){
                int valor = numAleatorio.Next(1,5000);
                vetor1[i] = valor;
            }

            for (int i = 0; i < 5; i++){
                int valor = numAleatorio.Next(1,1400);
                vetor2[i] = valor;
            }

            Array.Sort(vetor1);
            for (int i = 0; i < 5; i++){
                
                Console.WriteLine(vetor1[i]);
                
            }

            Console.WriteLine();
            Array.Sort(vetor2);
            for (int i = 0; i < 5; i++){
                
                Console.WriteLine(vetor2[i]);
            }

            
            vetor3 = vetor1.Concat(vetor2).ToArray();
            Array.Sort(vetor3);
            Console.WriteLine();
            foreach (int j in vetor3){
                Console.WriteLine(j);}
         }
    }
}
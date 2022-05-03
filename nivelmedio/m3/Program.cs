//Crie um programa que exiba para o usuário qual é a área de um retângulo. Para implementar esse programa você
//deverá seguir as seguintes regras:
//● O usuário deverá informar para o programa o valor da base e altura do retângulo/quadrado.
//● É obrigatório criar/utilizar uma classe para representar o retângulo/quadrado.
//● A base e a altura informada pelo usuário deveram ser representadas na classe como propriedades.
//● O objeto deverá possuir uma propriedade para exibir o valor da área do retângulo/quadrado.
//● O objeto deverá possuir um método que exiba os dados de todas as suas propriedades.
using System;

namespace m3
{
 //criar classe Retangulo e suas propriedades (atributos)
    public class Retangulo{
    public int baserec;
    public int alturarec;
    public int arearec;

//criar construtor da classe retângulo, configurando as características dos atributos
        public Retangulo(int b, int h){
            baserec = b;
            alturarec = h;
            arearec = b * h;
        }

//criar metodo para exibir os dados de todas as propriedades
        
        public string ResumoTxt(){
            string resumo = string.Format("Base: {0}, Altura: {1}, Área {2}", baserec, alturarec, arearec);
            return resumo;
        }

}

    class Program
    {
        static void Main(string[] args)
        {
            int valorbase;
            int altura;

            Console.WriteLine("informe valor inteiro para base:");
            valorbase = int.Parse(Console.ReadLine());
            Console.WriteLine("informe valor inteiro para altura");
            altura = int.Parse(Console.ReadLine());

            Retangulo Rec1 = new Retangulo(valorbase, altura);

            Console.WriteLine(Rec1.ResumoTxt());

            
        }
    }
}

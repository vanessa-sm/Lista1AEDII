/* 6) Crie um programa no qual o usuário deverá informar o nome e o tipo de cinco animais de estimação. O programa
deverá exibir na tela para o usuário quantos cachorros, gatos e peixes foram informados.
Regras que deverão ser seguidas para a implementação do algoritmo:
● Os únicos tipos de animais válidos são cachorro, gato e peixe.
● Caso seja informado um tipo diferente o programa deverá definir o tipo do animal como Peixe.
● É obrigatório criar uma classe para representar o Animal.
● A classe deverá possuir dois dados privados (propriedades) para representar as características do animal.
● A classe deverá possuir métodos de acesso para permitir que o usuário armazene/leia os dados dos dois
dados privados (propriedades).
 */
using System;
using System.Collections.Generic;  

class Animal{
    string nome {get;set;}
    string tipo {get;set;}
    bool tipoEhvalido;

    public Animal(string nom, string tp){
        nome = nom;
        tipo = tp;
        tipoEhvalido = true;
    }

    public Animal(){
        nome = "nomedopet";
        tipo = "tipopet";
        tipoEhvalido = true;
    }

    public int contagemCao(Animal ani1){
        int contaCao = 0;
        
        if (ani1.tipo == "cachorro")
        {
            contaCao = contaCao + 1; 
        }
        
            return contaCao;
               
    }

    public int contagemGato(Animal[] vetor, Animal ani1){
        
        int contaGato = 0;
        
        if (ani1.tipo == "gato"){
            contaGato = contaGato + 1; 
        }
        
        return contaGato;
    }

    public int contagemPeixe(Animal ani1){

        int contaPeixe = 0;

        if (ani1.tipo == "peixe"){
            contaPeixe = contaPeixe + 1; 
        }

        return contaPeixe;
    }
               

/*      public string exibeContagem(){
        string contagem = string.Format("Total de Cachorros: {0}, Total de Gatos: {1}, Total de Peixes: {2}", contaCao, contaGato, contaPeixe);
        return contagem;
    } */ 
    
}

class Program
{
    static void Main(string[]args){
        string nomeanimal;
        string tipoanimal;
        Animal []animais = new Animal[5];
        string []animaisvalidos = {"cachorro", "gato", "peixe"};
        //bool verificapet = true;

        for(int i=0; i<5; i++){
            Console.WriteLine("Informe o nome do Pet:");
            nomeanimal = Console.ReadLine();
            Console.WriteLine("Informe o tipo do Pet:");
            tipoanimal = Console.ReadLine();
            Animal novoanimal = new Animal(nomeanimal, tipoanimal);
            animais[i] = novoanimal;
                if (tipoanimal == animaisvalidos[0] || tipoanimal == animaisvalidos[1] || tipoanimal == animaisvalidos[2]){
                
                    
                    int totalCao = novoanimal.contagemCao(novoanimal);
                        Console.WriteLine("O total de cães é:", totalCao);
                }
                else{
                    tipoanimal = "peixe";
                    
                    int totalPeixe = novoanimal.contagemPeixe(novoanimal);
                    Console.WriteLine("O total de peixes é:", totalPeixe);
                }
                    
        }
            
        //Console.WriteLine(novoanimal.ExibeContagem());

        

    }

}
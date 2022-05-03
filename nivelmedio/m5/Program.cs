/* 5) Implemente um programa no qual o usuário deverá informar o nome e a idade de três pessoas. O programa deverá
informar o nome da pessoa que possuir a maior idade.
Regras que deverão ser seguidas para a implementação do algoritmo:
● É obrigatório o uso de classe para representar uma pessoa e ela deverá possuir como propriedades
(características) um nome e uma idade.
● A classe deverá possuir um método chamado ExibirDados. Esse método deverá exibir o nome e a idade da
pessoa em questão */


public class Pessoa{
    string nome;
    int idade;

    public Pessoa(){
        nome = "";
        idade = 0;
    }
    public Pessoa(string n, int i){
        nome = n;
        idade = i;
    }

    public string exibirDados(){
        string pes = string.Format("Nome: {0} e Idade: {1}", nome, idade);
        return pes;
    }
}

class Program
{
    static void Main(string[] args){
        string nomepessoa;
        int idadepessoa;
        int []idades = new int[3];
        string []nomes = new string[3];
        int maior = 0;
        string nomemaioridade;

        

        
        for(int i = 0; i < 3; i++){

            
            Console.WriteLine("Digite o nome:");
            nomepessoa = Console.ReadLine();
            Console.WriteLine("Digite a idade:");
            idadepessoa = int.Parse(Console.ReadLine());
            Pessoa novapessoa = new Pessoa(nomepessoa, idadepessoa);
            nomes[i] = nomepessoa;
            idades[i] = idadepessoa;
            
            Console.WriteLine(novapessoa.exibirDados());
        }

        for (int j = 0; j < 3; j++){
            if(maior < idades[j]){
                maior = idades[j];
            }
        }

        int indice = Array.IndexOf(idades, maior);
        nomemaioridade = nomes[indice];
        Console.WriteLine("A pessoa mais velha é {0}, com {1} anos", nomemaioridade, maior);

    }
}
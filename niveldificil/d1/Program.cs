/* //1) Desenvolva uma classe Lâmpada, a qual pode ser ligada e desligada. Também deve ser possível observar o
estado da lâmpada (se desligada ou ligada).
● Desenvolva uma nova classe para a lâmpada de forma a incluir as características de potência e voltagem.
Garanta que seja possível tanto ler quanto alterar os valores de potência e voltagem de uma lâmpada.
● Crie uma classe Teste com um método main para testar as classes desenvolvidas nos exercícios 1 e 2. Crie
uma lâmpada, apresente no console as informações de estado (se ligada ou desligada, potência e voltagem),
ligue a lâmpada e apresente novamente as informações de estado.
● Modifique a classe da lâmpada criada anteriormente para incluir o caso de uma lâmpada queimar ao ser
ligada. Sabe-se que existe uma chance de 15% da lâmpada queimar ao ser ligada. Dica: neste exercício é
importante pesquisar na biblioteca de classes fornecida pela linguagem de programação uma classe que dê
suporte à geração de números aleatórios */

public class Lampada{
    float potencia;
    float voltagem;
    bool ligarlampada;
    bool lampqueimada;
    //string lampAgora;

    public Lampada(float pot, float volt){
        
        potencia = pot;
        voltagem = volt;
        ligarlampada = true;
        lampqueimada = false;
        //lampAgora = "";
    }

    public void setPotencia (float novaPot){
        this.potencia = novaPot;
    }

    public float getPotencia(){
        return potencia;
    }

    public void setVoltagem (float novaVolt){
        this.voltagem = novaVolt;
    }

    public float getVoltagem (){
        return voltagem;
    }

    public void setLigar (bool novoEstado){
        this.ligarlampada = novoEstado;
    }

    public bool getLigarlamp (){
        return ligarlampada;
    }

    
    public void setQueimada(int num){
        switch (num)
        {
            case 1:
            case 2:
            case 3:
                lampqueimada = true;
                break;
            case 4:
            case 5:
            case 6:
            case 7:
            case 8:
            case 9:
            case 10:
            case 11:
            case 12:
            case 13:
            case 14:
            case 15:
            case 16:
            case 17:
            case 18:
            case 19:
            case 20:
                lampqueimada = false;
                break;
        }        
    }

    public string setLampAgora(){
        if (ligarlampada == true && lampqueimada == false){
            string lampAgora = "A lâmpada está acesa";
            return lampAgora;        
        }
        
        if (ligarlampada == false && lampqueimada == false){
            string lampAgora = "A lâmpada está apagada";
            return lampAgora;
        }
        else {
            string lampAgora = "A lâmpada está queimada";
            return lampAgora;
        }
         
    }
    public string exibeinfo()
    {        
        string infoLamp = string.Format("Potência {0} W, Tensão {1} V. {2}", this.getPotencia(), this.getVoltagem(), this.setLampAgora());
        return infoLamp;

    }

}

class Teste{
    static void Main(string[] args){
        Lampada lamp1 = new Lampada(150, 127);
        Random numAleatorio = new Random();
        int valorInteiro = numAleatorio.Next(1,20);
        
        lamp1.setQueimada(valorInteiro);

        lamp1.setLampAgora();

        Console.WriteLine("{0}",lamp1.exibeinfo());

        
    }
}
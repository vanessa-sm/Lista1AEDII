﻿// 4) Crie uma classe Ponto, com a capacidade de armazenar a localização de ponto no plano cartesiano, de modo que
/* ela possua três construtores:
● Um construtor sem parâmetros, que cria um ponto nas coordenadas (0,0);
● Um construtor que recebe dois parâmetros de coordenadas X e Y;
● Um construtor que inicializa o ponto através das coordenadas de um outro ponto recebido como parâmetro.
 */
using System;

public class Ponto{
    public float coordenadaX;
    public float coordenadaY;

        public Ponto(){
            coordenadaX = 0;
            coordenadaY = 0;
        }

        public Ponto(float x, float y){
            coordenadaX = x;
            coordenadaY = y;
        }

        public Ponto(Ponto pontoA){
            coordenadaX = pontoA.coordenadaX;
            coordenadaY = pontoA.coordenadaY;
        }

}
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class AdivinhaONumero : MonoBehaviour
{
    [SerializeField] int minimoInicio = 1;
    [SerializeField] int maximoInicio = 100;

    int minimo; //declaracao da variavel
    int maximo; //declaracao da variavel
    int valorAAdivinhar;

    // Start is called before the first frame update
    void Start()
    {
        InicioOJogo();
    }

    // Update is called once per frame
    void Update()
    {
        //O JOGADOR CARREGOU EM ALGUMA TECLA?
        if (Input.GetKeyDown(KeyCode.UpArrow)) //Sim - Se tiver pressionado; Não - caso contrário
        {
            minimo = valorAAdivinhar;
            CalculaEImprime();

            //Código a executar se o jogador pressionar a tecla para cim

        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //Código a executar se o jogador pressionar a tecla para baixo

            minimo = valorAAdivinhar;
            CalculaEImprime();

        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            //Código a executar se o jogador pressionar o Enter
            Debug.Log("Viste como sou um génio?!");

            InicioOJogo();

        }
    }

    void CalculaEImprime()
    {
        valorAAdivinhar = UnityEngine.Random.Range(minimo, maximo);


        Debug.Log("Eu acho que o número em que pensaste é " + valorAAdivinhar);

        Debug.Log("Para responderes");
        Debug.Log("Seta Cima - o número que pensaste é maior");
        Debug.Log("Seta Baixo - o número em que pensaste é menor");
        Debug.Log("Enter - o número em que pensaste é este!");
    }

    void InicioOJogo()
    {
        minimo = minimoInicio;   //este é o valor minimo do jogo
        maximo = maximoInicio; //este é o valor minimo do jogo


        /*
         * Operadores matemáticos
         * + Soma
         * - Subtração
         * * Multiplicação
         * / Divisao
         * % Resto da divisão inteira
         */

        Debug.Log("Olá, vamos jogar um jogo!");
        Debug.Log("Eu vou tentar adivinhar o número em que pensas");
        Debug.Log("Pensa num número entre" + minimo + " e " + maximo);

        CalculaEImprime();
    }
}

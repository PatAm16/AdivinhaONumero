using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdivinhaONumero : MonoBehaviour
{

    int minimo; //declaracao da variavel
    int maximo; //declaracao da variavel
    int valorAAdivinhar;

    // Start is called before the first frame update
    void Start()
    {
        minimo = 1;   //este é o valor minimo do jogo
        maximo = 100; //este é o valor minimo do jogo
        valorAAdivinhar = (minimo + maximo) / 2;


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

        Debug.Log("Eu acho que o número em que pensaste é 100");

        Debug.Log("Para responderes");
        Debug.Log("Seta Cima - o número que pensaste é maior");
        Debug.Log("Seta Baixo - o número em que pensaste é menor");
        Debug.Log("Enter - o número em que pensaste é este!");

    }

    // Update is called once per frame
    void Update()
    {
        //O JOGADOR CARREGOU EM ALGUMA TECLA?
        if (Input.GetKeyDown(KeyCode.UpArrow)) //Sim - Se tiver pressionado; Não - caso contrário
        {
            minimo = valorAAdivinhar;
            valorAAdivinhar = (minimo + maximo) / 2;

            //Código a executar se o jogador pressionar a tecla para cima

        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //Código a executar se o jogador pressionar a tecla para baixo
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            //Código a executar se o jogador pressionar o Enter
        }
    }
}

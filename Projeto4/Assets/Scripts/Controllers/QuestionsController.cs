using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionsController : MonoBehaviour
{
    public Text pergunta;
    public Text respostaA;
    public Text respostaB;
    public Text respostaC;


    public string[] perguntas;
    public string[] alternativasA;
    public string[] alternativasB;
    public string[] alternativasC;
    public string[] corretas;


    private int idPergunta;

    private float acertos;
    private float questoes;
    private float media;

void Start()
    {
        idPergunta = 0;
        questoes=perguntas.Length;
        pergunta.text = perguntas[idPergunta];
        respostaA.text = alternativasA[idPergunta];
        respostaB.text = alternativasB[idPergunta];
        respostaC.text = alternativasC[idPergunta];

    }

    public void resposta(string alternativa)
    {
        if (alternativa == "A")
        {
            if (alternativasA[idPergunta] == corretas[idPergunta])
               {
                acertos += 1;
            }
        }
        else if (alternativa == "B")
        {
            if (alternativasB[idPergunta] == corretas[idPergunta])
               {
                acertos += 1;
            }
        }

        else if (alternativa == "C")
        {
            if (alternativasC[idPergunta] == corretas[idPergunta])
               {
                acertos += 1;
            }
        }
        proximaPergunta();
    }


    void proximaPergunta()
    {

        idPergunta += 1;
    

        pergunta.text = perguntas[idPergunta];
        respostaA.text = alternativasA[idPergunta];
        respostaB.text = alternativasB[idPergunta];
        respostaC.text = alternativasC[idPergunta];


    }

}

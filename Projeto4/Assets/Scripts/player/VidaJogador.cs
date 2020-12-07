using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaJogador : MonoBehaviour
{
    MonetizationManager monetizationManager;
    GameOver GameOverScript;

    public int vidaMaxima;
    public int vidaAtual;
    public Text texto;
    public GameObject reset;
    public GameObject player;
    

    
    void Start()
    {
        monetizationManager = FindObjectOfType<MonetizationManager>();
        GameOverScript = FindObjectOfType<GameOver>();
        vidaAtual = vidaMaxima;
        texto = GameObject.Find("Player_Life").GetComponent<Text>();
        texto.text = vidaAtual.ToString();
    }

    
    void Update()
    {

    }


    public void ReceberDano()
    {
        vidaAtual -= 1;
        texto.text = vidaAtual.ToString();

        if (vidaAtual <= 0)
        {
            Debug.Log("Game Over");
            GameOverScript.openMorteMenu();
        }
        else
        {
            monetizationManager.ShowInterstitial();
        }
    }
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            player.transform.position = reset.transform.position;
            ReceberDano();
        }
    }

    public void Reviver()
    {
        texto.text = vidaAtual.ToString();
        vidaAtual = 3;
    }
}


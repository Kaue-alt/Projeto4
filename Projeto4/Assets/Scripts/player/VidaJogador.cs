using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaJogador : MonoBehaviour
{
    MonetizationManager monetizationManager;

    public int vidaMaxima;
    public int vidaAtual;
    public Text texto;
    public GameOver GameOverScript;
    public Enemy EnemyScript;

    
    void Awake()
    {

        GameOverScript = GetComponent<GameOver>();
        EnemyScript = GetComponent<Enemy>();
    }

    void Start()
    {
        monetizationManager = FindObjectOfType<MonetizationManager>();
        vidaAtual = vidaMaxima;
        texto = GameObject.Find("Player_Life").GetComponent<Text>();
        texto.text = vidaAtual.ToString();
    }

    // Update is called once per frame
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
            GameOverScript.GetComponent<GameOver>().openMorteMenu();
        }
        else
        {
            monetizationManager.ShowInterstitial();
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            ReceberDano();
            EnemyScript.GetComponent<Enemy>().Colisao();
        }
    }
}

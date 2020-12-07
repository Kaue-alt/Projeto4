using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    VidaJogador vidaJogador;
    MonetizationManager monetizationManager;
    public GameObject morteMenu;
    
    void Start()
    {
        monetizationManager = FindObjectOfType<MonetizationManager>();
        vidaJogador = FindObjectOfType<VidaJogador>();
    }

    
    void Update()
    {
        
    }

    public void openMorteMenu()
    {
        morteMenu.SetActive(true);
    }
    public void goMainMenu()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }

    public void adsButton()
    {
        morteMenu.SetActive(false);
        monetizationManager.ShowInterstitial();
        vidaJogador.Reviver();
    }
}

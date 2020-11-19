using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    public GameObject morteMenu;
    
    void Start()
    {
        
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

    }
}

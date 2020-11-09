using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseandMEnuController : MonoBehaviour
{
    public GameObject pauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void openPauseMenu()
    {
        pauseMenu.SetActive(true);
    }

    public void closePauseMenu()
    {
        pauseMenu.SetActive(false);

    }

    public void goToMainMenu()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }

    public void loadroom()
    {

    } 
}

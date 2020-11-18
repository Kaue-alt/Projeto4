using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControllers : MonoBehaviour
{
       public void goToGame(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}

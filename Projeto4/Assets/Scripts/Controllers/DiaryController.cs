using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiaryController : MonoBehaviour
{
    public GameObject painelDiario;
    public GameObject info;
    public GameObject textodiario;
    public GameObject botaodiario;
    public GameObject scrollButton;
    public GameObject aviso;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showdiary()
    {
        painelDiario.SetActive(true);
        if (GameObject.Find("Scroll") == enabled)
        {
            scrollButton.SetActive(true);
            aviso.SetActive(false);
        }
        else
        {
            scrollButton.SetActive(false);
            aviso.SetActive(true);
        }
        

    }

    public void showinfo()
    {
        info.SetActive(true);
        textodiario.SetActive(false);
        botaodiario.SetActive(false);

    }

    public void returndiary()
    {
        info.SetActive(false);
        textodiario.SetActive(true);
        botaodiario.SetActive(true);


    }

    public void closediary()
    {
        painelDiario.SetActive(false);
    }
}

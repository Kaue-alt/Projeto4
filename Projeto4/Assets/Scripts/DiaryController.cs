using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiaryController : MonoBehaviour
{
    public GameObject painelDiario;
    public GameObject info;
    public GameObject textodiario;
    public GameObject botaodiario;
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

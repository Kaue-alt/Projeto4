using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiaryController : MonoBehaviour
{
    public GameObject painelDiario;

    public GameObject infoScroll;
    public GameObject infoMask;
    public GameObject infoVase;
    public GameObject infoTablet;
    public GameObject infoBandage;

    public GameObject textodiario;
    public GameObject botaodiario;
    public GameObject scrollButton;
    public GameObject maskButton;
    public GameObject vaseButton;
    public GameObject bandageButton;
    public GameObject tabletButton;




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
            
        }
        else
        {
            scrollButton.SetActive(false);
            
        }
        if (GameObject.Find("Mask") == enabled)
        {
            maskButton.SetActive(true);
            
        }
        else
        {
            maskButton.SetActive(false);
           
        }
        if (GameObject.Find("Vase") == enabled)
        {
            vaseButton.SetActive(true);
          
        }
        else
        {
            vaseButton.SetActive(false);
        }
        if (GameObject.Find("Bandage") == enabled)
        {
            bandageButton.SetActive(true);
           
        }
        else
        {
            bandageButton.SetActive(false);
            
        }
        if (GameObject.Find("Tablet") == enabled)
        {
            tabletButton.SetActive(true);
            
        }
        else
        {
            tabletButton.SetActive(false);
            
        }


    }

    public void showinfo()
    {
        infoScroll.SetActive(true);
        textodiario.SetActive(false);
        botaodiario.SetActive(false);

    }

    public void showinfo2()
    {
        infoMask.SetActive(true);
        textodiario.SetActive(false);
        botaodiario.SetActive(false);

    }
    public void showinfo3()
    {
        infoBandage.SetActive(true);
        textodiario.SetActive(false);
        botaodiario.SetActive(false);

    }

    public void showinfo4()
    {
        infoVase.SetActive(true);
        textodiario.SetActive(false);
        botaodiario.SetActive(false);

    }

    public void showinfo5()
    {
        infoTablet.SetActive(true);
        textodiario.SetActive(false);
        botaodiario.SetActive(false);

    }

    public void returndiary()
    {
        infoScroll.SetActive(false);
        infoTablet.SetActive(false);
        infoVase.SetActive(false);
        infoMask.SetActive(false);
        infoBandage.SetActive(false);

        textodiario.SetActive(true);
        botaodiario.SetActive(true);


    }

    public void closediary()
    {
        painelDiario.SetActive(false);
    }
}

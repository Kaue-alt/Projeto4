using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Colectables : MonoBehaviour
{
    public GameObject scrollImage;
    

    public float cont=0f;

    private void Update()
    {
        cont ++;
        if (cont == 1f)
        {
            cont = 0;
            enabled = false;
        }
    }
    private void OnEnable()
    {
        scrollImage.SetActive(true);
        GameObject.Find("Pergaminho").SetActive(false);
        

        
    }
}

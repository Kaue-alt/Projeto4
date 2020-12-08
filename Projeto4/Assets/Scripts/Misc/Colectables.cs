using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Colectables : MonoBehaviour
{
    public GameObject scrollImage;
    public GameObject maskImage;
    public GameObject tabletImage;
    public GameObject vaseImage;
    public GameObject bandageImage;




    private AudioSource somItem;


    

    void Awake()
    {
        somItem = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (GameObject.Find("Pergaminho") == false)
        {
            scrollImage.SetActive(true);
            //somItem.Play();
        }

        if (GameObject.Find("Tutancamon") == false)
        {
            maskImage.SetActive(true);
            //somItem.Play();
        }
        if (GameObject.Find("Bandagem") == false)
        {
            bandageImage.SetActive(true);
            //somItem.Play();
        }
        if (GameObject.Find("Vaso") == false)
        {
            vaseImage.SetActive(true);
            //somItem.Play();
        }
        if (GameObject.Find("Anubis") == false)
        {
            tabletImage.SetActive(true);
            //somItem.Play();
        }
    }
    
}

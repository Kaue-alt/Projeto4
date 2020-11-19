using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Colectables : MonoBehaviour
{
    public GameObject scrollImage;
    public GameObject maskImage;

   
   

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
            somItem.Play();
        }

        if (GameObject.Find("Tutancamon") == false)
        {
            maskImage.SetActive(true);
            somItem.Play();
        }
    }
    
}

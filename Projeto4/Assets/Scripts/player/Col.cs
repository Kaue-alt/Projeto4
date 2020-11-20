using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Col : MonoBehaviour
{
    public GameObject scrollImage;


   

   
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
    }
    
}



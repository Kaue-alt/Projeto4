using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Col : MonoBehaviour
{
    public GameObject scrollImage;
    public GameObject maskImage;

    public GameObject pergaminho;
    public GameObject mascara;

    public int distance = 4;

    private AudioSource somItem;


    public float cont = 0f;

    void Awake()
    {
        somItem = GetComponent<AudioSource>();
    }

    private void Update()
    {
        
        if (cont == 1f)
        {
            scrollImage.SetActive(true);
            GameObject.Find("Pergaminho").SetActive(false);
            somItem.Play();
            enabled = false;
        }

        if(cont == 2f)
        {
            maskImage.SetActive(true);
            GameObject.Find("Tutancamon").SetActive(false);
            somItem.Play();
        }
    }
    private void OnEnable()
    {
        cont++;
    }
}



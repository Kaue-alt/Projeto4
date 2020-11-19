using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Colectables : MonoBehaviour
{
    public GameObject scrollImage;
    public GameObject maskImage;

    public GameObject pergaminho;
    public GameObject mascara;
    
    public int distance = 4;

    private AudioSource somItem;


    public float cont=0f;

    void Awake()
    {
        somItem = GetComponent<AudioSource>();
    }

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
            somItem.Play();



         maskImage.SetActive(true);
         GameObject.Find("Tutancamon").SetActive(false);
         somItem.Play();


    }
}

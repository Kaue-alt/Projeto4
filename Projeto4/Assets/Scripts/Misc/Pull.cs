using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pull : MonoBehaviour
{
    public Transform theDestR;
    public Transform theDestL;
   


    public Transform player;


    private AudioSource soundPedra;

    void Awake()
    {
        soundPedra = GetComponent<AudioSource>();
    }
    public void OnEnable()
    {
        if (this.transform.position.x > player.transform.position.x)
        {
            this.transform.position = theDestR.transform.position;
            this.transform.parent = GameObject.Find("Destination_Right").transform;
            soundPedra.Play();

        }
        else if (this.transform.position.x < player.transform.position.x)
        {
            this.transform.position = theDestL.transform.position;
            this.transform.parent = GameObject.Find("Destination_Left").transform;
            soundPedra.Play();

        }
        //else if (this.transform.position.y < player.transform.position.y)
        //{
        //    this.transform.position = theDestD.transform.position;
        //    this.transform.parent = GameObject.Find("Destination_Down").transform;
        //    soundPedra.Play();

        //}
        //else if (this.transform.position.y > player.transform.position.y)
        //{
        //    this.transform.position = theDestU.transform.position;
        //    this.transform.parent = GameObject.Find("Destination_Up").transform;
        //    soundPedra.Play();

        //}






    }
    private void OnDisable()
    {
        this.transform.position = this.transform.position;
        this.transform.parent = null;
    }
}

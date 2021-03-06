﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentacao : MonoBehaviour
{
    public float velocidade;
    public float h;
    public float v;

    public FloatingJoystick joystick;

    public Animator animator;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Colectable"))
        {
            other.gameObject.SetActive(false);
        }
    }





    // Update is called once per frame
    void Update()
    {
        //Movimentação no teclado: ADWS
        //h = Input.GetAxis("Horizontal");
        //v = Input.GetAxis("Vertical");

        //Movimentação no joystick virtual
        h = joystick.Horizontal;
        v = joystick.Vertical;


        

        transform.Translate(new Vector3(h, v, 0) * velocidade * Time.deltaTime);

        Animate();



    }


    void Animate()
    {
        animator.SetFloat("Horizontal", joystick.Horizontal);
        animator.SetFloat("Vertical",joystick.Vertical);
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentacao : MonoBehaviour
{
    public float velocidade;
    public float h;
    public float v;

    public FloatingJoystick joystick;
    

    

    



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

        



    }
}

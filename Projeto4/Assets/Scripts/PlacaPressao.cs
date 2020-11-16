using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacaPressao : MonoBehaviour
{
    //apagar primeira linha do script da sala e ver o problema das rooms q esta apenas em uma sala
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("pushable"))
        {
            Debug.Log("ativou");
        }
    }

}
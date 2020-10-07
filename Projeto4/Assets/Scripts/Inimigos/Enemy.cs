using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public float distance;

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {     
            transform.eulerAngles = new Vector3(0, 180, 0);
            Debug.Log("deu certo");      
    }
}

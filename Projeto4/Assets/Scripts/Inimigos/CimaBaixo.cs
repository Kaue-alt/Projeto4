using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CimaBaixo : MonoBehaviour
{
    
    
    public float speed;
    public GameObject reset;
    public GameObject player;
    
    bool isRight;

    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
    

    
    void OnCollisionEnter2D(Collision2D collision)
    {
            if (isRight)
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                isRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(180, 0, 0);
            //this.GetComponent<SpriteRenderer>
                isRight = true;
                
            }
            
    }
        
    
}

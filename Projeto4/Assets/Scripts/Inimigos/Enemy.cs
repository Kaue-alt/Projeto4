using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
   
    public float speed;
    public GameObject reset;
    public GameObject player;
    private VidaJogador VidaJogadorScript;

    bool isRight;

    void Awake()
    {

        VidaJogadorScript = GetComponent<VidaJogador>();
    }
    void Start()
    {
        
    }
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
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
                transform.eulerAngles = new Vector3(0, 180, 0);
                isRight = true;
            }
                       
            if (collision.collider.CompareTag("Player"))
            {
                player.transform.position = reset.transform.position;
                collision.gameObject.GetComponent<VidaJogador>().ReceberDano();
                

            }
            
    }
    
}

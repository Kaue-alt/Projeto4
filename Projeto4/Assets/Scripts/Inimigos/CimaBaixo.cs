using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CimaBaixo : MonoBehaviour
{
    MonetizationManager monetizationManager;

    public float speed;
    public GameObject reset;
    public GameObject player;

    bool isRight;

    void Start()
    {
        monetizationManager = FindObjectOfType<MonetizationManager>();
    }
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
            transform.eulerAngles = new Vector3(0, 0, 0);
            isRight = true;
        }
        if (collision.collider.CompareTag("Player"))
        {
            player.transform.position = reset.transform.position;
            monetizationManager.ShowInterstitial();

        }
    }
}

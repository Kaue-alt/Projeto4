using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    public static CameraController instance;

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            CameraController.instance.SetPosition(new Vector2(transform.position.x, transform.position.y));
        }
    }
}

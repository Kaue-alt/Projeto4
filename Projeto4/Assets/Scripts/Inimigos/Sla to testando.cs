using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slatotestando : MonoBehaviour
{
    public float speed;
    public float distance;

    
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
}

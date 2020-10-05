using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pull : MonoBehaviour
{
    public Transform theDest;

    public void OnEnable()
    {
        this.transform.position = theDest.transform.position;
        this.transform.parent = GameObject.Find("Destination").transform;
    }
    private void OnDisable()
    {
        this.transform.position = this.transform.position;
        this.transform.parent = null;
    }

    



}

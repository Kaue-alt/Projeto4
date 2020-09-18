using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pull : MonoBehaviour
{
    public Transform theDest;
    
    private void grab()
    {
        this.transform.position = theDest.transform.position;
        this.transform.parent = GameObject.Find("Destination").transform;
    }

    private void disgrab()
    {
        this.transform.position = this.transform.position;;
    }



}

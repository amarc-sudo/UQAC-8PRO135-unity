using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingActor : MonoBehaviour
{
    private float z;
    
    void Start () {
        z = 0.5f;  //velocity
    }
     
    void Update () {
        transform.Rotate(new Vector3(0,0,z)); //applying rotation
    }
}

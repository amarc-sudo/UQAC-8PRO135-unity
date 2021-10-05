using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bonksound : MonoBehaviour
{
     

    public AudioSource aSource ;
   

    void OnCollisionEnter()  //Plays Sound Whenever collision detected
    {
        aSource.Play();
    }
}

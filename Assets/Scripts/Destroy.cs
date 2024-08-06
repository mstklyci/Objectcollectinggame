using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{


    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("can") || collision.gameObject.CompareTag("dusman"))
        { 
            Destroy(collision.gameObject); 
        }
    }
}
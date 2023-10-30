using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class bala : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject)
        {
            Destroy(gameObject);
        }        
    }

    private void Start()
    {
        Invoke("destruir", 3f);
    }

    public void destruir()
    {
        Destroy(gameObject);
    }
}

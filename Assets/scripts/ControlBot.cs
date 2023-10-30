using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBot : MonoBehaviour
{
    private int hp;
    public GameObject gamer;
    public int velocidad;
    public gamescore gamescore;

    void Start()
    {
        hp = 100;       
    }

    private void Update()
    {
        transform.LookAt(gamer.transform);
        transform.Translate(velocidad * Vector3.forward * Time.deltaTime);
    }

    public void recibirDaño()
    {
        hp = hp - 25;

        if (hp <= 0)
        {
            this.desaparecer();
            gamescore.numerito();
        }
    }

    private void desaparecer()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        recibirDaño();
    }
}

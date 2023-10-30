using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlJuego : MonoBehaviour
{
    public GameObject gamer;
    public GameObject bot;
    private List<GameObject> listaenemigos;
    float tiemporestante;

    void Start()
    {
        ComenzarJuego();
    }

    void Update()
    {
        if (tiemporestante == 0)
        {
            ComenzarJuego();
        }
    }

    void ComenzarJuego()
    {
        gamer.transform.position = new Vector3(0f, 0f, 0f);

        foreach (GameObject item in listaenemigos)
        {
            Destroy(item);
        }

        listaenemigos.Add(Instantiate(bot, new Vector3(5, 1f, 3f), Quaternion.identity));
        listaenemigos.Add(Instantiate(bot, new Vector3(3, 1f, 3f), Quaternion.identity));
        listaenemigos.Add(Instantiate(bot, new Vector3(1, 1f, 3f), Quaternion.identity));

        

    }

}

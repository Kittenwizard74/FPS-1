using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gamescore : MonoBehaviour
{
    int contador;
    public Text numeroEnemigos;

    private void Start()
    {
        numeroEnemigos.text = "enemigos eliminados " + contador;
    }

    public void numerito()
    {
        contador++;
        numeroEnemigos.text = "enemigos eliminados " + contador; 

        if (contador >= 5) 
        {
            SceneManager.LoadScene(1);
        }
    }
}

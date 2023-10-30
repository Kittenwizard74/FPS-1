using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamermove : MonoBehaviour
{
    public float velocidad = 10f;
    public camara camaraPrimeraPersona;
    public GameObject bala;
    public Transform piwpiw;
    public float speed;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
   
    void Update()
    {
        float movimientoAdelanteAtras = Input.GetAxis("Vertical") * velocidad * Time.deltaTime;
        float movimientoStrafe = Input.GetAxis("Horizontal") * velocidad * Time.deltaTime;

        transform.Translate(movimientoStrafe, 0, movimientoAdelanteAtras);

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
        }

        if (Input.GetMouseButtonDown(0))
        {
            var bullet = Instantiate(bala, piwpiw.position, piwpiw.rotation);
            bullet.GetComponent<Rigidbody>().velocity = piwpiw.transform.right * speed;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bot"))
        {
            SceneManager.LoadScene(0);
        }
    }
}

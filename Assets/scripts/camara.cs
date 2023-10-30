using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{
    Vector2 mousemirar;
    Vector2 smooth;

    public float sensibilidad = 5.0f;
    public float suavizado = 2.0f;

    GameObject gamer;

     void Start()
    {
        gamer = this.transform.parent.gameObject;
    }

     void Update()
     {
        var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

        md = Vector2.Scale(md, new Vector2(sensibilidad * suavizado, sensibilidad * suavizado));

        smooth.x = Mathf.Lerp(smooth.x, md.x, 1f / suavizado);
        smooth.y = Mathf.Lerp(smooth.y, md.y, 1f / suavizado);

        mousemirar += smooth;
        mousemirar.y = Mathf.Clamp(mousemirar.y, -90f, 90f);
        transform.localRotation = Quaternion.AngleAxis(-mousemirar.y, Vector3.right);
        gamer.transform.localRotation = Quaternion.AngleAxis(mousemirar.x, gamer.transform.up);
     }

}

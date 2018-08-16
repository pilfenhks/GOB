using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public float speedPlayer;

    private void Update()
    {
        Acciones();//inicia la funcion de las acciones
    }
   
    public void Acciones()
    {
        //teclas
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.up * speedPlayer * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.up * speedPlayer * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * speedPlayer * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * speedPlayer * Time.deltaTime;
        }
    }
}

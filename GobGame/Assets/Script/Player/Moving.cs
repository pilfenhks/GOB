using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public float speedPlayer;
    Player player;
    private void Start()
    {
        player = FindObjectOfType<Player>();
    }
    private void Update()
    {
        Acciones();//inicia la funcion de las acciones
    }

    public void Acciones()
    {
        //teclas
        if (Input.GetKey(KeyCode.W) && player.tocaMuroU == false)
        {
            transform.position += transform.up * speedPlayer * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S) && player.tocaMuroD == false)
        {
            transform.position -= transform.up * speedPlayer * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D) && player.tocaMuroR == false)
        {
            transform.position += transform.right * speedPlayer * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A) && player.tocaMuroL == false)
        {
            transform.position -= transform.right * speedPlayer * Time.deltaTime;
        }
    }
}

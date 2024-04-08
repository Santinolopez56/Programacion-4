using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cuadrado : MonoBehaviour
{
    public float velocidad = 10f;

    private Vector3 puntoB = new Vector3(7.5f, 4f, 0f);
    private Vector3 puntoC = new Vector3(8f, -4.15f, 0f);

    private bool Movimiento = false;
    private Vector3 destino;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !Movimiento)
        {
            Movimiento = true;
            destino = puntoB;
        }
        if (Movimiento)
            transform.position = Vector3.MoveTowards(transform.position, destino, velocidad = Time.deltaTime);
        if (transform.position == destino)
        {
            if (destino == puntoB)
                destino = puntoC;
            else if (destino == puntoC)
                Movimiento = false;
        }
    }
}

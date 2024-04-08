using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    public float velocidad = 0.1f;
    public float rotationSpeed = 50f;
    public KeyCode teclaDerecha;
    public KeyCode teclaArriba;
    public KeyCode teclaIzquierda;
    public KeyCode teclaAbajo;
    public KeyCode teclaRotacion;
    public KeyCode teclaRotacion2;

    public Transform target;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(teclaDerecha))
            target.Translate(Vector3.right*velocidad);
        
        if (Input.GetKey(teclaIzquierda))
            target.Translate(Vector3.left * velocidad);

        if (Input.GetKey(teclaArriba))
            target.Translate(Vector3.up * velocidad);
        
        if (Input.GetKey(teclaAbajo))
            target.Translate(Vector3.down * velocidad);

        if (Input.GetKey(teclaRotacion))
           target.transform.Rotate(new Vector3(0,0,velocidad));

        if (Input.GetKey(teclaRotacion2))
            target.transform.Rotate(new Vector3(0, 0, -velocidad));
    }
    void RotateTarget()
    {
        target.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}

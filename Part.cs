using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part : MonoBehaviour
{
    Vector3 initPos;
    float margenError = 0.5f;

    void Awake()
    {
        initPos= transform.position;
    }
    // Start is called before the first frame update
    void Start()
    {
        Vector3 newPos = new Vector3 (Random.Range(-4, 4), Random.Range(-4, 4), 0);
        transform.position = newPos;    
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(initPos, transform.position);
        if (distance < margenError) {
            transform.position = initPos;
        }
        
    }
}

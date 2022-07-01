using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raqueta : MonoBehaviour
{
    //Velocidad
    public float velocidad=30.0f;

    
    public string ejev;
    public string ejeh;

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {   
        float v=Input.GetAxisRaw(ejev);

        float h=Input.GetAxisRaw(ejeh);
        GetComponent<Rigidbody2D>().velocity=new Vector2(h*velocidad,v * velocidad);        
    }
}

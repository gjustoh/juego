using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    public float velocidad= 10f;
    public float rotacion = 200.0f;
    public Animator animacion;
    public float x,y;

    // Start is called before the first frame update
    void Start()
    {
        animacion = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        x=Input.GetAxis("Horizontal");
        y=Input.GetAxis("Vertical");
        x=-x;
        y=-y;
        transform.Rotate(0,-x*Time.deltaTime*rotacion,0);
        transform.Translate(x*Time.deltaTime*velocidad, 0, -y*Time.deltaTime*velocidad);
        // transform.Translate(0,0,y*Time.deltaTime*velocidad);
        animacion.SetFloat("VelX",x);
        animacion.SetFloat("VelY",y);
    }
}

using Cinemachine;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class bola : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] Vector3 direccion;
    [SerializeField] int velocidad;
    [SerializeField] Vector3 direccionSalto;
    [SerializeField] int fuerzasalto;
    [SerializeField] int fuerza;
    [SerializeField] int vida;
    private int puntuacion;

    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        direccion.x = h;
        direccion.z = v;
        rb.AddForce(direccion.normalized * fuerza, ForceMode.Force);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(direccionSalto * fuerzasalto, ForceMode.Impulse);

        }

            
            

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "collecionable")
        {
            Destroy(other.gameObject);
            vida -= 10;
        }
        if (other.gameObject.CompareTag("trampa"))
        {
            Destroy(other.gameObject);
            vida -= 10;
        }
        if (vida <= 0)
        {
            Destroy(this.gameObject);
        }
    }
        
    
}

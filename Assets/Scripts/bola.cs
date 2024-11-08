using Cinemachine;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bola : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] Vector3 direccion;
    [SerializeField] int velocidad;
    [SerializeField] Vector3 direccionSalto;
    [SerializeField] int fuerzasalto;
    [SerializeField] int fuerza;
    [SerializeField] int vida;
    private int coleccionable;
    [SerializeField] TMP_Text textoColeccionable;
    [SerializeField] AudioClip sonidoMoneda;
    [SerializeField] AudioManager manager;
    [SerializeField] float distanciaDeteccionSuelo;
    [SerializeField] LayerMask queEsSuelo;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        textoColeccionable.SetText("Coleccionable: " + coleccionable);
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        direccion.x = h;
        direccion.z = v;
        rb.AddForce(direccion.normalized * fuerza, ForceMode.Force);
        

            
            

    }
    void Salta()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(direccionSalto * fuerzasalto, ForceMode.Impulse);

        }

    }
    bool DetectarSuelo()
    {
        bool resultado = Physics.Raycast(transform.position, new Vector3(0, -1, 0), distanciaDeteccionSuelo, queEsSuelo);
        return resultado;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag ("coleccionable"))
        {
            manager.ReproducirSonido(sonidoMoneda);
            vida -= 10;
            coleccionable++;
            textoColeccionable.SetText("Coleccionable: " + coleccionable);
            Destroy(other.gameObject);
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
        if (other.gameObject.CompareTag("pared"))
        {
            Time.timeScale = 0.1f;
        }
        if (other.gameObject.CompareTag ( "morir"))
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene(2);
        }
        if (other.gameObject.CompareTag ( "ganar"))
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene(3);
        }
    }
        
    
}

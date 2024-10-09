using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{
    [SerializeField] Vector3 direccion = new Vector3(0, 0, 0);
    [SerializeField] int velocidad;
    float timer = 0;
    
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direccion * velocidad * Time.deltaTime);
        timer += 1 * Time.deltaTime;
        if (timer >= 1.6)
        {
            direccion = direccion * -1;
            timer = 0;
            direccion = direccion * 1;
        }
        
        
    }
}

using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bola : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] Vector3 direccion;
    
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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, 1, 0) * 2, ForceMode.Impulse);

        }
            rb.AddForce(direccion * 2, ForceMode.Impulse);
            

    }
}

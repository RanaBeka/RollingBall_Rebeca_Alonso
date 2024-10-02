using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bola : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        transform.Translate(new Vector3(h, 0 , 0) * 1 * Time.deltaTime, Space.World);
        transform.Translate(new Vector3(0, 0, v) * 1 * Time.deltaTime, Space.World);
    }
}

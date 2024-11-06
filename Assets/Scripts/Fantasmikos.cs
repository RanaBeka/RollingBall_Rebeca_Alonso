using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fantasmikos : MonoBehaviour
{
    Vector3 direccion = new Vector3(0, 1, 0);
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 1, 0 * 2 * Time.deltaTime, Space.World);
        transform.Translate(direccion * 0.5f * Time.deltaTime, Space.World);
        timer += 1 * Time.deltaTime;
        if (timer >= 0.5f)
        {
            direccion = direccion * -1;
            timer = 0;
            direccion = direccion * 1;
        }
    }
}

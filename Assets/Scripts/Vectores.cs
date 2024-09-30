using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vectores : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(3, 5, 0);
        transform.eulerAngles = new Vector3(10, 45, 90);
        transform.localScale = new Vector3(2, 4, 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

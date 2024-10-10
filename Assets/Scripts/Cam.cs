using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    [SerializeField] private GameObject Directional;
    [SerializeField] private GameObject Cenital;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Directional.SetActive(false);
            Cenital.SetActive(true);
        }
        else
        {
            Directional.SetActive(true);
            Cenital.SetActive(false);
        }
    }
}

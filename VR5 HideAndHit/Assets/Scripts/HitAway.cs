using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitAway : MonoBehaviour
{

    //private Rigidbody rb;

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
        //rb = other.GetComponent<Rigidbody>();
        //rb.AddForce(0, 500.0f, 500.0f);
    }
}

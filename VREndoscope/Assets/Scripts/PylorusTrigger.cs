using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PylorusTrigger : MonoBehaviour
{

    public Animator Pylorus;

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
        Pylorus.SetBool("PylorusOpen", true);
    }

    private void OnTriggerExit(Collider other)
    {
        Pylorus.SetBool("PylorusOpen", false);
    }
}

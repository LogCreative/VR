using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardiaTrigger : MonoBehaviour
{

    public Animator Cardia;

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
        Cardia.SetBool("CardiaOpen", true);
    }

    private void OnTriggerExit(Collider other)
    {
        Cardia.SetBool("CardiaOpen", false);
    }
}

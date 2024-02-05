using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouthTrigger : MonoBehaviour
{

    public Animator Animater;

    // Start is called before the first frame update
    void Start()
    {
        Animater.SetBool("OpenMouthBool", false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Animater.SetBool("OpenMouthBool", true);
        Animater.SetBool("HoldOpen", true);
        
    }
    private void OnTriggerExit(Collider other)
    {
        Animater.SetBool("HoldOpen", false);
        Animater.SetBool("OpenMouthBool", false);
    }
}

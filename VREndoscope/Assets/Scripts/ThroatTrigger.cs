using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThroatTrigger : MonoBehaviour
{

    public Animator AnimaterW, AnimaterER, AnimaterEL;

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
        AnimaterW.SetBool("ThroatTouch", true);
        AnimaterW.SetBool("KeepOpen", true);
        AnimaterER.SetBool("ThroatOpen", true);
        AnimaterER.SetBool("HoldClose", false);
        AnimaterEL.SetBool("ThroatOpen", true);
        AnimaterEL.SetBool("HoldClose", false);
    }

    private void OnTriggerExit(Collider other)
    {
        AnimaterW.SetBool("ThroatTouch", false);
        AnimaterW.SetBool("KeepOpen", false);
        AnimaterER.SetBool("ThroatOpen", false);
        AnimaterER.SetBool("HoldClose", true);
        AnimaterEL.SetBool("ThroatOpen", false);
        AnimaterEL.SetBool("HoldClose", true);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollideWithChara : MonoBehaviour
{

    public Text PtText;
    public Text GetText;

    private int pt;
    private Animator anim;
    private Rigidbody rb;
    private int hit_timer;

    // Start is called before the first frame update
    void Start()
    {
        pt = 10;
        PtText.text = "Pt:" + pt;
        anim = GetComponent<Animator>();
        hit_timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        hit_timer += 1;

        if (hit_timer>100)
        {
            anim.SetBool("Hit", false);
            hit_timer = 0;
            
        }
        if (pt <= -10)
        {
            anim.SetBool("Dead", true);
            Destroy(this.gameObject,4);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        anim.SetBool("Hit", true);

        if (hit_timer > 35 && hit_timer < 58)
        {
            rb = other.GetComponent<Rigidbody>();
            rb.AddForce(0, 500.0f, 500.0f);
            pt++;
            GetText.enabled = true;
        }
        else
        {
            pt--;
            hit_timer = 0;
            GetText.enabled = false;
        }
        PtText.text = "Pt:" + pt;
        
    }
}

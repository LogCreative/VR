using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//底板的随机6DOF规则（尚未完成），通过键盘控制四角（完成）

public class PlaneController : MonoBehaviour
{
    public float amp;
    public float randomamp;
    public float randomamprotate;
    public int freshrate;

    private float timeCount;

    void Start()
    {
        timeCount = 0.0f;
    }

    
    void FixedUpdate()
    {
        float mV=0.0f;
        int xsgn = 0;
        int zsgn = 0;

        //W=-X-Z,S=+X+Z,A=+X-Z.D=-X+Z, the controller is complete.

        if (Input.anyKey)
        {
            if (Input.GetKey(KeyCode.W))
            {
                xsgn = -1;
                zsgn = -1;
            }
            else if (Input.GetKey(KeyCode.S))
            {
                xsgn = 1;
                zsgn = 1;
            }
            else if (Input.GetKey(KeyCode.A))
            {
                xsgn = 1;
                zsgn = -1;
            }
            else if (Input.GetKey(KeyCode.D))
            {
                xsgn = -1;
                zsgn = 1;
            }
            mV = Input.GetAxis("Vertical");
            transform.Rotate(new Vector3(xsgn * mV * amp, 0.0f, zsgn * mV * amp));
        }

        transform.position += new Vector3(Random.Range(-randomamp, randomamp), Random.Range(-randomamp, randomamp), Random.Range(-randomamp, randomamp));
        //transform.Rotate(new Vector3(Random.Range(-randomamprotate, randomamprotate), Random.Range(-randomamprotate, randomamprotate), Random.Range(-randomamprotate, randomamprotate)));
        if (timeCount >= Time.deltaTime * freshrate){
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(transform.eulerAngles.x + Random.Range(-randomamprotate, randomamprotate),
           transform.eulerAngles.y + Random.Range(-randomamprotate, randomamprotate), transform.eulerAngles.z + Random.Range(-randomamprotate, randomamprotate)), Time.deltaTime);
            timeCount = 0.0f;
        }
        timeCount = timeCount + Time.deltaTime;
    }
}

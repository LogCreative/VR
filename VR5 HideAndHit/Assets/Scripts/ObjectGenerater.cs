using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGenerater : MonoBehaviour
{

    public GameObject Capsule;
    public GameObject Sphere;
    public GameObject Cylinder;
    public GameObject Cube;
    public GameObject GamePlane;
    public GameObject Camera;
    public GameObject Player;

    public float diammid;
    public int generdelta;

    //Clone Object
    GameObject CloneCap, CloneSphe, CloneCyl, CloneCube;

    private Rigidbody rb;
    private float range = 5.0f;
    private float throwobj;
    private int genertimer = 0;
    private float diam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        genertimer += 1;

        //transform.position = new Vector3(Camera.transform.position.x, 
        //   Camera.transform.position.y, 
        //   Camera.transform.position.z+0.5f);

        if (genertimer >= generdelta)
        {
            genertimer = 0; //初始化

            throwobj = Random.Range(-1.0f, 1.0f);
            diam = diammid + Random.Range(-130.0f, 0.0f);

            if (throwobj < -0.5f)
            {
                CloneCap = GameObject.Instantiate(Capsule,
                this.transform.position + Random.Range(-range, range) * Vector3.one + new Vector3(0.0f, 0.0f, 0.0f),
                Player.transform.rotation) as GameObject;
                rb = CloneCap.GetComponent<Rigidbody>();
                rb.AddForce(new Vector3(Random.Range(-range, range) * 100, diam, -diam));
                Destroy(CloneCap.gameObject, 5);
            }
            else if (throwobj < 0.0f)
            {
                CloneSphe = GameObject.Instantiate(Sphere,
                this.transform.position + Random.Range(-range, range) * Vector3.one + new Vector3(0.0f, 0.0f, 0.0f),
                Player.transform.rotation) as GameObject;
                rb = CloneSphe.GetComponent<Rigidbody>();
                rb.AddForce(new Vector3(Random.Range(-range, range) * 100, diam, -diam));
                Destroy(CloneSphe.gameObject, 5);
            }
            else if (throwobj < 0.5f)
            {
                CloneCyl = GameObject.Instantiate(Cylinder,
                this.transform.position + Random.Range(-range, range) * Vector3.one + new Vector3(0.0f, 0.0f, 0.0f),
                Player.transform.rotation) as GameObject;
                rb = CloneCyl.GetComponent<Rigidbody>();
                rb.AddForce(new Vector3(Random.Range(-range, range) * 100, diam, -diam));
                Destroy(CloneCyl.gameObject, 5);
            }
            else
            {
                CloneCube = GameObject.Instantiate(Cube,
                this.transform.position + Random.Range(-range, range) * Vector3.one + new Vector3(0.0f, 0.0f, 0.0f),
                Player.transform.rotation) as GameObject;
                rb = CloneCube.GetComponent<Rigidbody>();
                rb.AddForce(new Vector3(Random.Range(-range, range) * 100, diam, -diam));
                Destroy(CloneCube.gameObject, 5);
            }

            //Destroy的碰撞方法未知，这里使用了延时方法
        }
    }
}
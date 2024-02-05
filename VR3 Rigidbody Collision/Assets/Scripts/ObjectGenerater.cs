using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectGenerater : MonoBehaviour
{
    public GameObject Capsule;
    public GameObject Sphere;
    public GameObject Cylinder;
    public GameObject Cube;
    public GameObject GamePlane;

    public Text textcount;
    public float randomrange;


    GameObject cloneObjCap, cloneObjSphe, cloneObjCylin, cloneObjCube;

    int cap, sphe, cylin, cube;
    public int count;

    void Start()
    {
        count = 0;
        textcount.text = count.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        cloneObjCap = GameObject.Instantiate(Capsule, GamePlane.transform.position + new Vector3(Random.Range(-randomrange, randomrange), 20.0f, Random.Range(-randomrange, randomrange)), Quaternion.identity) as GameObject;
        cloneObjSphe = GameObject.Instantiate(Sphere, GamePlane.transform.position + new Vector3(Random.Range(-randomrange, randomrange), 20.0f, Random.Range(-randomrange, randomrange)), Quaternion.identity) as GameObject;
        cloneObjCylin = GameObject.Instantiate(Cylinder, GamePlane.transform.position + new Vector3(Random.Range(-randomrange, randomrange), 20.0f, Random.Range(-randomrange, randomrange)), Quaternion.identity) as GameObject;
        cloneObjCube = GameObject.Instantiate(Cube, GamePlane.transform.position + new Vector3(Random.Range(-randomrange, randomrange), 20.0f, Random.Range(-randomrange, randomrange)), Quaternion.identity) as GameObject;
        count = count + 4;
        textcount.text = count.ToString();


        //if (cloneObjCap.transform.position.y < GamePlane.transform.position.y )
        //    Destroy(cloneObjCap);
        //if (cloneObjSphe.transform.position.y < GamePlane.transform.position.y )
        //    Destroy(cloneObjSphe);
        //if (cloneObjCylin.transform.position.y < GamePlane.transform.position.y )
        //    Destroy(cloneObjCylin);
        //if (cloneObjCube.transform.position.y < GamePlane.transform.position.y )
        //    Destroy(cloneObjCube);
    }
}
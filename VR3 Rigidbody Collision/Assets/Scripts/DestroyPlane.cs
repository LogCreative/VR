using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlane : MonoBehaviour
{
    public GameObject GamePlane;

    public GameObject Goal;


    int count;
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
       
        Vector3 IncreaseY = new Vector3(0, -20, 0);
        transform.position = GamePlane.transform.position+IncreaseY;
        
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Goal.GetComponent<ObjectGenerater>().count--;
    }

}

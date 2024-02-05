using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTracking : MonoBehaviour
{

   // public GameObject player;

    //private Vector3 offset,offsetshadow;
    //private float yrotation; //偏向角，摄像机保持相同高度

    // Start is called before the first frame update
    void Start()
    {
        //offset = transform.position - player.transform.position;
        //offsetshadow = offset - new Vector3(0, offset.y, 0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //transform.position = player.transform.position + offset;
        //transform.rotation = Quaternion.Euler(0.0f, -player.transform.rotation.eulerAngles.y + 180.0f, 0.0f);
        //yrotation = player.transform.rotation.eulerAngles.y;

        /*transform.position = player.transform.position + new Vector3(
            offsetshadow.magnitude * Mathf.Sin(yrotation),
            offset.y,
            offsetshadow.magnitude * Mathf.Cos(yrotation));
        transform.rotation = Quaternion.Slerp(transform.rotation,Quaternion.Euler(new Vector3(
            player.transform.rotation.eulerAngles.x,
            180.0f - player.transform.rotation.eulerAngles.y,
            player.transform.rotation.eulerAngles.z)),Time.deltaTime);*/
        //不需要了
    }
}

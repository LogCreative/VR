using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement1 : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //float x_move;
        float z_move;
        //x_move = Input.GetAxis("RTrackPadHorizontal");
        //z_move = Input.GetAxis("RTrackPadVertical"); //Replace when fixed

        z_move = Input.GetAxis("Vertical");
        print(z_move);

        Vector3 moveDirection = transform.up;

        transform.position -= moveDirection * z_move;

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class RightSimu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        float v = -CrossPlatformInputManager.GetAxis("Horizontal");
        this.transform.Rotate(v * new Vector3(0.0f, 0.0f, 1.0f));
    }
}

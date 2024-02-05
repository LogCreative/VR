using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR; //引入VR包
using Valve.VR.InteractionSystem;

public class Test : MonoBehaviour
{

    Hand hand;

    // Start is called before the first frame update
    void Start()
    {
        hand = gameObject.GetComponent<Hand>();
    }

    // Update is called once per frame
    void Update()
    {
        //方法SteamVR_Input._default等丢失

        print(hand.handType);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if VR
using Valve.VR; //引入VR包
using Valve.VR.InteractionSystem;
#endif

public class Test : MonoBehaviour
{
#if VR
    Hand hand;
#endif

    // Start is called before the first frame update
    void Start()
    {
#if VR
        hand = gameObject.GetComponent<Hand>();
#endif
    }

    // Update is called once per frame
    void Update()
    {
        //方法SteamVR_Input._default等丢失
#if VR
        print(hand.handType);
#endif
        
    }
}

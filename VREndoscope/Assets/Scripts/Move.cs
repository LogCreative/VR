using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#if VR
using Valve.VR;
using Valve.VR.Extras;
using Valve.VR.InteractionSystem;
#endif

public class Move : MonoBehaviour
{

    public GameObject Camera;
    public GameObject straw;
    public Text FwdText;
    public Text RotText;
#if VR
    public SteamVR_Action_Boolean trigger;
    public SteamVR_Action_Boolean grip;
#endif
    public Animator StrawAnim;

#if VR
    public SteamVR_Action_Vector2 Ltrackpadaxis, Rtrackpadaxis;
    public SteamVR_Input_Sources LTrackpad, RTrackpad;
    public SteamVR_Action_Boolean LTrackPadTouch, RTrackPadTouch;

    public SteamVR_Action_Boolean True { get; private set; }
#endif
    public int rota = 0; //Rotate of the camera

    float fwdtotal;

    Vector3 StrawMove;

    // Start is called before the first frame update
    void Start()
    {
        fwdtotal = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        float x_move;
        float z_move;


        Vector3 moveDirection = Camera.transform.forward; //Functional when using helmet
        StrawMove = Camera.transform.forward / 30;
        //None VR Ver.

        if ((z_move = Input.GetAxis("Vertical"))!=0)
        {
            FwdText.text = "Fwd: " + z_move;
            transform.position += moveDirection * z_move;
        }

        if ((x_move = Input.GetAxis("Horizontal")) != 0)
        {
            
            transform.Rotate(x_move, 0, 0);
        }

#if VR
        //VR ver.
        //x_move = Input.GetAxis("Horizontal");
        //z_move = Input.GetAxis("RTrackPadVertical");

        float fwdvalue, risevalue;

        fwdvalue = Rtrackpadaxis.GetAxis(RTrackpad).y;
        risevalue = Ltrackpadaxis.GetAxis(LTrackpad).y;
        //horivalue = Ltrackpadaxis.GetAxis(LTrackpad).x;

        if (RTrackPadTouch.GetState(RTrackpad))
        {
            FwdText.text = "Fwd: " + fwdvalue;
            transform.position += moveDirection * fwdvalue / 30;
        }
        

        if (LTrackPadTouch.GetState(LTrackpad))
        {
            transform.Rotate(risevalue, 0, 0);
        }

        RotText.text = "Rot: " + transform.localEulerAngles.x;

        //Control the Straw

        if (trigger.GetState(SteamVR_Input_Sources.LeftHand))
        {
            if (fwdtotal >= 0.0f && fwdtotal <= 2.7f)
            {
                if (StrawAnim.GetBool("StrawClose") == false)
                {

                    straw.transform.position += StrawMove;//前进
                    fwdtotal += 0.03f;

                }
                else
                {

                    straw.transform.position -= StrawMove;//后退
                    fwdtotal -= 0.03f;

                }
            }
            else
            {
                if (fwdtotal >= 2.7f)
                {
                    fwdtotal = 2.6f;
                }
                else
                {
                    fwdtotal = 0.0f;
                }
            }
        }

        if (grip.GetState(SteamVR_Input_Sources.LeftHand))
        {
            if (StrawAnim.GetBool("StrawClose") == false)
            {
                StrawAnim.SetBool("StrawClose", true);
            }
        }
        else
        {
            StrawAnim.SetBool("StrawClose", false);
        }

#endif

        /*

        if (trigger.GetState(SteamVR_Input_Sources.LeftHand))
        {
            FwdText.text = "Fwd: " + 1;

            Vector3 moveDirection = Camera.transform.forward; //Functional when using helmet
            
            transform.position += moveDirection/30;
            //transform.position += moveDirection * z_move;
        }
        if (grip.GetState(SteamVR_Input_Sources.LeftHand))
        {
            FwdText.text = "Bck: " + 1;

            Vector3 moveDirection = Camera.transform.forward; //Functional when using helmet

            transform.position -= moveDirection/30;
            //transform.position += moveDirection * z_move;
        }

        */

            /*

            if (trigger.GetState(SteamVR_Input_Sources.RightHand))//
            {
                rota += 1;
                transform.rotation = Quaternion.Euler(rota/3,0,0);
                //transform.position += moveDirection * z_move;
            }
            if (grip.GetState(SteamVR_Input_Sources.RightHand))//
            {
                rota -= 1;
                transform.rotation = Quaternion.Euler(rota / 3, 0, 0);
                //transform.position += moveDirection * z_move;
            }
            //FwdText.text = "Fwd: " + z_move;

            //if (trackpad.GetAxis(Valve.VR.EVRButtonId.k_EButton_Axis0))
            //{ }

            */

            /*
            trackpadpos = trackpadaxis.GetAxis(Rtrackpad);
            transform.rotation = Quaternion.Euler(trackpadpos.y / 3, 0, 0);
            */

    }
}

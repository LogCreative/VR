using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof(CarController))]
    public class CarUserControl : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use

        public GameObject Lefthand, Righthand;

        public float leftangle_old, rightangle_old;//初始值
        public float angleavg;

        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();

            leftangle_old = 0.0f;
            rightangle_old = 0.0f;
        }


        private void FixedUpdate()
        {
            {
                // pass the input to the car!

                //方向控制

                float leftangle, rightangle;

                leftangle = Lefthand.transform.rotation.eulerAngles.z - 180.0f; //switch to -180.0f to 180.0f
                rightangle = Righthand.transform.rotation.eulerAngles.z - 180.0f;
                angleavg = (leftangle + rightangle) / 720.0f; //avg + standardarization(180 degrees on each side)
                
                //print(angleavg);

                //leftangle_old = 0.0f;
                //rightangle_old = 0.0f;
                //leftangle_old = Lefthand.transform.rotation.eulerAngles.z;
                //rightangle_old = Righthand.transform.rotation.eulerAngles.z;

                float h = angleavg;

                float v = CrossPlatformInputManager.GetAxis("RightTrigger"); //油门
                v = CrossPlatformInputManager.GetAxis("Vertical");
#if !MOBILE_INPUT
                float handbrake = CrossPlatformInputManager.GetAxis("LeftTrigger"); //刹车
                handbrake = CrossPlatformInputManager.GetAxis("Jump");
                m_Car.Move(h, v, v, handbrake);
#else
            m_Car.Move(h, v, v, 0f);
#endif
            }
        }
    }
}

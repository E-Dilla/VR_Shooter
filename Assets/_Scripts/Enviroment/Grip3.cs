using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Valve.VR.InteractionSystem
{

    public class Grip3 : MonoBehaviour
    {
        public GameObject gripvalue;
        private LinearMapping value;
        public float grip1;
        public bool grip3got;

        void Start()
        {
            value = GetComponentInChildren<LinearMapping>();

        }

        void Update()
        {
            grip1 = value.value;
            if (grip1 >= .9f && grip1 <= .95f)
            {
                grip3got = true;
            }
            else
            {
                grip3got = false;
            }

            if (grip3got)
            {
                Debug.Log("Grip3");
            }
            //anim.SetBool("Lift", true);
        }

    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Valve.VR.InteractionSystem
{

    public class Grip1 : MonoBehaviour
    {
        public GameObject gripvalue;
        private LinearMapping value;
        public float grip1;
        public bool grip1got;

        void Start()
        {
            value = GetComponentInChildren<LinearMapping>();

        }

        void Update()
        {
            grip1 = value.value;
            if (grip1 >= .4f && grip1 <= .45f)
            {
                grip1got = true;
            }
            else
            {
                grip1got = false;
            }

            if (grip1got)
            {
                Debug.Log("Grip1");
            }
            //anim.SetBool("Lift", true);
        }

    }
}


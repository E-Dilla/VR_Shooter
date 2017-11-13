using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Valve.VR.InteractionSystem
{

    public class Grip2 : MonoBehaviour
    {
        public GameObject gripvalue;
        private LinearMapping value;
        public float grip1;
        public bool grip2got;

        void Start()
        {
            value = GetComponentInChildren<LinearMapping>();

        }

        void Update()
        {
            grip1 = value.value;
            if (grip1 >= .6f && grip1 <= .65f)
            {
                grip2got = true;
            }
            else
            {
                grip2got = false;
            }

            if (grip2got)
            {
                Debug.Log("Grip2");
            }
            //anim.SetBool("Lift", true);
        }

    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grip : MonoBehaviour {

    public bool isOnPlace1 = false;
    public bool isOnPlace2 = false;
    public bool isOnPlace3 = false;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("End1"))
        {
            isOnPlace1 = true;
        }

        if (other.CompareTag("End2"))
        {
            isOnPlace2 = true;
        }

        if (other.CompareTag("End3"))
        {
            isOnPlace3 = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("End1"))
        {
            isOnPlace1 = false;
        }

        if (other.CompareTag("End2"))
        {
            isOnPlace2 = false;
        }

        if (other.CompareTag("End3"))
        {
            isOnPlace3 = false;
        }
    }


}

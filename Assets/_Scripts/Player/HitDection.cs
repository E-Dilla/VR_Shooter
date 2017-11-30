using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HitDection : MonoBehaviour {

    public Slider healthbar;
    public GameObject sign;
    public bool isDead = false;

    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.tag == "hands")
        {
            healthbar.value -= 30;
        }

        if(healthbar.value <= 0)
        {
            isDead = true;
            sign.SetActive(true);
            //Destroy(gameObject);
        }
    }
}

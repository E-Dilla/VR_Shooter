using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roller : MonoBehaviour {

    private Animator anim;
    grip[] handle = null;
    private bool lift1 = false;
    private grip _grip;

    public bool oneOn = false;
    public bool twoOn = false;
    public bool threeOn = false;

    // Use this for initialization
    void Start() {


        anim = GetComponent<Animator>();
        handle = GameObject.FindObjectsOfType<grip>();
        _grip = GetComponent<grip>();
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckforWin();
        win();
    }

    public void CheckforWin()
    {
        foreach (grip H in handle)
        {
            if (H.isOnPlace1)
            {
                oneOn = true;
            }
            if (H.isOnPlace2)
            {
                twoOn = true;
            }
            if (H.isOnPlace3)
            {
                threeOn = true;
            }
            else
            {
                threeOn = false;
            }
        }
    }
        
    void win()
    {
        if (oneOn && twoOn && threeOn)
        {
            Debug.Log("Work");
        }
    }
        
        
        
        /*
       
        */

    }


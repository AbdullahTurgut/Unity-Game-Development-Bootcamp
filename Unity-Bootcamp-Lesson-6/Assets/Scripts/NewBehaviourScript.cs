using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Animator animasyon;
    void Start()
    {
        animasyon = GetComponent<Animator>();
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            rotOpen();
        }
        else
        {
            animasyon.SetBool("Active", false);
        }
    }

    void rotOpen()
    {
        animasyon.SetBool("Active", true);
    }
}

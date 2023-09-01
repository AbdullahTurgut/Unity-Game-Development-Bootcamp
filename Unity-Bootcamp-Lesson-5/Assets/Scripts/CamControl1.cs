using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControl1 : MonoBehaviour
{
    public float moveSpeed = 5.0f;

    void Update()
    {

       float horizontal = Input.GetAxis("Horizontal");
       float vertical = Input.GetAxis("Vertical");
      
       Vector3 moveDirection = new Vector3(horizontal, 0, vertical) * moveSpeed * Time.deltaTime;
       transform.Translate(moveDirection);

    }

    
}

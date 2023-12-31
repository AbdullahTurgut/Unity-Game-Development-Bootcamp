using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotate : MonoBehaviour
{
    public Vector2 turn;
    public float sensitivity = .5f;
    public Vector3 deltaMove;
    public float speed =1.0f;
    public GameObject mover;
   void Start()
    {
        // Mouse gösterimi kitlendi
        Cursor.lockState = CursorLockMode.Locked;
    }
    
    void Update()
    {
        turn.x += Input.GetAxis("Mouse X") * sensitivity;
        turn.y += Input.GetAxis("Mouse Y") * sensitivity;
        mover.transform.localRotation = Quaternion.Euler(0,turn.x, 0);
        transform.localRotation = Quaternion.Euler(-turn.y,0, 0.0f);

        deltaMove = new Vector3(Input.GetAxisRaw("Horizontal"),0,Input.GetAxisRaw("Vertical")) * speed * Time.deltaTime;
        mover.transform.Translate(deltaMove);
    }
}

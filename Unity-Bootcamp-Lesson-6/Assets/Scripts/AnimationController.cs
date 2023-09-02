using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float jumpingPower = 5f;

    bool isJumping;
    Rigidbody rb;
    Animator animator;

    // camera rotation
    public Transform cam;
    public Vector2 turn;

    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        turn.x += Input.GetAxis("Mouse X");
        turn.y += Input.GetAxis("Mouse Y");
        cam.localRotation = Quaternion.Euler(-turn.y, turn.x, 0.0f);


        if (Input.GetKey("w"))
        {
            // Movement Of Character
            walkingAnim();
            Vector3 movement = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")) * moveSpeed * Time.deltaTime;
            transform.Translate(movement);
        }
        else
        {
            animator.SetBool("Walking", false);
        }

        if (Input.GetKeyDown(KeyCode.Space) && !isJumping && !Input.GetKey("w"))
        {
            jumpingAnim();
            rb.AddForce(Vector3.up * jumpingPower, ForceMode.Impulse);
            isJumping = true;
        }
    }
    void walkingAnim()
    {
        animator.SetBool("Walking", true);
    }
    void jumpingAnim()
    {
        animator.SetBool("Jumping", true);
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
            animator.SetBool("Jumping", false);
        }
    }
}

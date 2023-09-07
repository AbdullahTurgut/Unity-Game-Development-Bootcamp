
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpingPower = 5f;

    public float moveSpeed = 3f;
    public float sensitivity = .5f;
    public Vector3 deltaMove;
    private Vector2 turn;
    public Transform cam;

    Rigidbody rb;
    Animator anim;
    private bool isJumping;
    private bool isCrouching;
    

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        MoveAndRotate(moveSpeed);
        // Movement Of Character
        if (Input.GetKey(KeyCode.LeftShift) && !Input.GetKey("w"))
        {
            isCrouching = true;
            crouchingAnim();

        }
        else
        {
            isCrouching = false;
            anim.SetBool("Crouching", false);
        }
            
       


        if (Input.GetKey("w") && !isCrouching)
        {
            walkingAnim();
            anim.SetFloat("BackCrouchWalking", 1f);
            if (Input.GetKey(KeyCode.LeftControl))
            {
                float crouchWalkingSpeed = 2f;
                MoveAndRotate(crouchWalkingSpeed);
                crouchWalkingAnim();
            }
            else
            {
                anim.SetBool("CrouchWalking", false);
            }


            if (Input.GetKey("r"))
            {
                float runningSpeed = 10f;
                MoveAndRotate(runningSpeed);
                runningAnim();
            }
            else
            {
                anim.SetBool("Running", false);
            }
        }
        else if (Input.GetKey("s") && !isCrouching)
        {
            anim.SetFloat("BackSpeed", -1f);
            walkingAnim();

            if (Input.GetKey(KeyCode.LeftControl))
            {
                anim.SetFloat("BackCrouchWalking", -1f);
                float crouchWalkingSpeed = 2f;
                MoveAndRotate(crouchWalkingSpeed);
                crouchWalkingAnim();
            }
            else
            {
                anim.SetFloat("BackCrouchWalking", 1f);
                anim.SetBool("CrouchWalking", false);
            }
        }
        else
        {
            anim.SetFloat("BackSpeed", 1f);
            anim.SetBool("Walking", false);
           
        }
        

        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            jumpingAnim();
            rb.AddForce(Vector3.up * jumpingPower, ForceMode.Impulse);
            isJumping = true;
        }
    }

    // Movement And Rotate
    private void MoveAndRotate(float moveSpeed)
    {
        // Movement and Rotate
        turn.x += Input.GetAxis("Mouse X") * sensitivity;
        turn.y += Input.GetAxis("Mouse Y") * sensitivity;
        transform.localRotation = Quaternion.Euler(0, turn.x, 0);
        cam.localRotation = Quaternion.Euler(-turn.y, 0, 0.0f);

        deltaMove = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")) * moveSpeed * Time.deltaTime;
        transform.Translate(deltaMove);
    }

    // Changing Animator Bools To True
    void crouchWalkingAnim()
    {
        anim.SetBool("CrouchWalking", true);
    }
    void crouchingAnim()
    {
        anim.SetBool("Crouching", true);
    }
    void walkingAnim()
    {
        anim.SetBool("Walking", true);
    }
    void jumpingAnim()
    {
        anim.SetBool("Jumping", true);
    }
    void runningAnim()
    {
        anim.SetBool("Running", true);
    }

    // Ground Collision
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
            anim.SetBool("Jumping", false);
        }
    }
}

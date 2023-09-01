using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementSpeed = 4f;
    public float jumpingPower = 8f;
    bool isUp = false;
    void Update()
    {

        float horizontal = Input.GetAxis("Horizontal"); // sað / sað-aþaðý / sol / sol-aþaðý
        float vertical = Input.GetAxis("Vertical"); // ileri / geri

        Vector3 movement = new Vector3(horizontal, 0f, vertical) * movementSpeed * Time.deltaTime;
        transform.Translate(movement);

        // Zýplama Olayý
        if (Input.GetKeyDown(KeyCode.Space) && !isUp)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpingPower,ForceMode.Impulse);
            isUp = true;
        }





      //  float movement = movementSpeed * Time.deltaTime; // time.deltaTime tüm cihazlarda eþitlik için
      //
      //  if (Input.GetKey(KeyCode.W)) // kullanýcý girdisi W almak için -- Basýlý tutulduðu sürece
      //  {
      //      transform.Translate(Vector3.forward * movement);
      //  }
      //  if (Input.GetKey(KeyCode.S))
      //  {
      //      transform.Translate(Vector3.back * movement);
      //  }
      //  if (Input.GetKey(KeyCode.A))
      //  {
      //      transform.Translate(Vector3.left * movement);
      //  }
      //  if (Input.GetKey(KeyCode.D))
      //  {
      //      transform.Translate(Vector3.right * movement);
      //  }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Zemin")){
            isUp = false;
        }
    }
}

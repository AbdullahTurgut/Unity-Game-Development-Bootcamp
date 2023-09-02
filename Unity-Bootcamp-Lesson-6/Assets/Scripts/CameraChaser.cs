using UnityEngine;

public class CameraChaser : MonoBehaviour
{
    public Transform player;
    
    public float chaseSpeed = 0.125f;
    public Vector3 offset;
    void LateUpdate()
    {
        
       // Vector3 offset = player.position - transform.position; // camera ve player arasý mesafe alýndý
        Vector3 distance = player.position + offset; // player ile aradaki mesafe korunuyor
        transform.position = Vector3.Lerp(transform.position,distance,chaseSpeed);
    }

}

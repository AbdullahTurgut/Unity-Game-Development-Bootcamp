using UnityEngine;

public class CameraChaser : MonoBehaviour
{
    public Transform player;
    
    public float chaseSpeed = 0.125f;

    Vector3 offset;
    Vector3 distance;

    private void Start()
    {
        offset = transform.position - player.transform.position;
    }
    void LateUpdate()
    {
         // camera ve player arasý mesafe alýndý
        distance = player.transform.position + offset; // player ile aradaki mesafe korunuyor
        transform.position = Vector3.Lerp(transform.position,distance,chaseSpeed);
    }

}

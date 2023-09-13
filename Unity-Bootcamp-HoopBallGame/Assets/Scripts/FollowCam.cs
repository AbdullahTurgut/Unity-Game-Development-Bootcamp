using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FollowCam : MonoBehaviour
{
    public Transform Player;
    
    void Update()
    {
        // Player takip
        if(Player.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x,Player.position.y,transform.position.z);
        }
        // Player Camera alanýndan çýktýðýnda
        if(Player.position.y + 5f < transform.position.y)
        {
            Debug.Log("Game Over!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}

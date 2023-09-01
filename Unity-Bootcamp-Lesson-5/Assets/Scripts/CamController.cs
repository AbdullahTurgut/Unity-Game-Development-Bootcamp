using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
    public Camera[] cameras;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0;i < cameras.Length; i++)
        {
            if(Input.GetKeyDown(KeyCode.Alpha1 + i))
            {
                switchTheCamera(i);
            }
        }
    }

    void switchTheCamera(int index)
    {
        for(int i = 0; i < cameras.Length; i++)
        {
            cameras[i].enabled = (i == index);
        }
    }
}

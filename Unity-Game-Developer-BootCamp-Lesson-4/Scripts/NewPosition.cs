using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(Random.Range(0,5) ,Random.Range(0,5) ,Random.Range(0,5));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

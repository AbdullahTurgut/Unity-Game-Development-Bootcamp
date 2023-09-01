using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newScript : MonoBehaviour
{
    public GameObject cloneObject;
    int maxObjectNumber = 5;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < maxObjectNumber; i++)
        {
            Vector3 position = new Vector3(Random.Range(0, 5), Random.Range(0, 5), Random.Range(0, 5));
            GameObject newCloneObject = Instantiate(cloneObject, position, Quaternion.identity);
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericTutorial : MonoBehaviour
{


    void Start()
    {
        Debug.Log(getType(2)); // 2 d�nd�r�r. int olarak ne girdi verirsek type olarak d�nd�r�r.
    }

    private T getType<T>(T type)
    {
        return type;
    }
}

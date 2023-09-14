using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericTutorial : MonoBehaviour
{


    void Start()
    {
        Debug.Log(getType(2)); // 2 döndürür. int olarak ne girdi verirsek type olarak döndürür.
    }

    private T getType<T>(T type)
    {
        return type;
    }
}

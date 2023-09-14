using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateExample : MonoBehaviour
{
    delegate void MyDelegate(string message);
    void Start()
    {
        // i�lev atama
        MyDelegate myDelegate = SomeFunction;
        // delegate �a��rma
        myDelegate("SomeFunction");

        // ba�ka bir delegate atama
        myDelegate = AnotherFunction;

        // ba�ka delegate �a�r�ld�
        myDelegate("AnotherFunction");

        // �u �ekilde ard���k i�lem yapt�rabiliriz
        myDelegate += SomeFunction;
        myDelegate("SomeFunction");

    }

    private void AnotherFunction(string message)
    {
        Debug.Log("AnotherFunction " + message);
    }

    private void SomeFunction(string message)
    {
        Debug.Log("SomeFunction " + message);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

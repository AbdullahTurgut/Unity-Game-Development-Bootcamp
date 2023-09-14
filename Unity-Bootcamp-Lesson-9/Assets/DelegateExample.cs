using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateExample : MonoBehaviour
{
    delegate void MyDelegate(string message);
    void Start()
    {
        // iþlev atama
        MyDelegate myDelegate = SomeFunction;
        // delegate çaðýrma
        myDelegate("SomeFunction");

        // baþka bir delegate atama
        myDelegate = AnotherFunction;

        // baþka delegate çaðrýldý
        myDelegate("AnotherFunction");

        // þu þekilde ardýþýk iþlem yaptýrabiliriz
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

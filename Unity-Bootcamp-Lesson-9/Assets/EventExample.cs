using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventExample : MonoBehaviour
{
    public event Action OnButtonClick;

    void Start()
    {
        OnButtonClick += HandleButtonClick; // bu þekilde abone ettik methodumuza

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnButtonClick?.Invoke(); // 
        }
    }

    private void HandleButtonClick()
    {
        Debug.Log("Clicked");
    }
}

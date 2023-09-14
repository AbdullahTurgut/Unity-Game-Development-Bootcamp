using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventListener : MonoBehaviour
{
    private EventExample eventExample;

    void Start()
    {
        eventExample = FindObjectOfType<EventExample>(); // buras� �nemli, olmazsa bile�ene bulunamaz!
        
        if(eventExample != null)
        {
            eventExample.OnButtonClick += HandleButtonClick;
        }
        else
        {
            Debug.LogError("EventExample bile�eni bulunamad�!");
        }
    }

    private void HandleButtonClick()
    {
        Debug.Log("Space tu�una bas�ld� ve EventListener taraf�ndan i�lendi.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventListener : MonoBehaviour
{
    private EventExample eventExample;

    void Start()
    {
        eventExample = FindObjectOfType<EventExample>(); // burasý önemli, olmazsa bileþene bulunamaz!
        
        if(eventExample != null)
        {
            eventExample.OnButtonClick += HandleButtonClick;
        }
        else
        {
            Debug.LogError("EventExample bileþeni bulunamadý!");
        }
    }

    private void HandleButtonClick()
    {
        Debug.Log("Space tuþuna basýldý ve EventListener tarafýndan iþlendi.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

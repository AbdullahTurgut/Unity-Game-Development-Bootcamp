using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UnityEventTutorial : MonoBehaviour
{
    public Light targetLight; // ýþýk nesnesi için

    public UnityEvent onClickEvent;

    

    void Start()
    {
        Button button = GetComponent<Button>();

        button.onClick.AddListener(OnButtonClick);
    }

    public void OnButtonClick()
    {
        onClickEvent.Invoke();

        if (targetLight != null)
        {
            targetLight.enabled = !targetLight.enabled;
        }
    }

    
}

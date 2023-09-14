using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Transform[] panels;
    private int panelIndex = 0;

    public GameObject levelsBtn, panel;
    void Start()
    {
       for(int i = 0; i < panels.Length; i++)
       {
            panels[i].gameObject.SetActive(i == panelIndex);
       }

        // Kayan level menüsü
        Sprite[] levels = Resources.LoadAll<Sprite>("Levels");

        foreach(Sprite level in levels)
        {
            GameObject obje = Instantiate(levelsBtn) as GameObject;

            obje.GetComponent<Image>().sprite = level;

            obje.transform.SetParent(panel.transform, false);

            string sceneName = level.name;

            obje.GetComponent<Button>().onClick.AddListener(() => LoadLevel(sceneName));
        }

    }

    private void LoadLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void ButtonClick(int hedefPanelIndex)
    {
        panels[panelIndex].gameObject.SetActive(false);

        panels[hedefPanelIndex].gameObject.SetActive(true);

        panelIndex = hedefPanelIndex;
    }
    void Update()
    {
        
    }
}

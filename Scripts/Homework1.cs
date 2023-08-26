using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework1 : MonoBehaviour
{
    public int playerHealt = 70;
    public float playerScore = 0.0f;
    public string endingMessage = "";
    void Start()
    {
        isPlayerAlive(playerHealt);
        scoreMaterials(playerScore);
        endingSceneMessage(endingMessage);
    }
    void endingSceneMessage(string endingMessage)
    {
        int count = 60;
        while (count >= 0)
        {
            count--;
        }
        endingMessage = "Your time has over!";
        Debug.Log(endingMessage);
    }
    void scoreMaterials(float playerScore)
    {
        string materialName = "gold";
        switch (materialName)
        {
            case "gold":
                playerScore += 35.5f;
                break;
            case "silver":
                playerScore += 25.8f;
                break;
            default:
                playerScore += 0.5f;
                break;
                
        }
        Debug.Log("Newest player score is " + playerScore);
    }
    void isPlayerAlive(int playerHealt)
    {
        if(playerHealt <= 30)
        {
            Debug.Log("You're in trouble!");
        }
        else if(playerHealt <= 70)
        {
            Debug.Log("You're good! ");
        }
        else
        {
            Debug.Log("Healthly! ");
        }
    }


  //  void Update()
  //  {
  //      
  //  }
}

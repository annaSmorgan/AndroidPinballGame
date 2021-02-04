using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour{ //class to handle to the score, writing to screen, increasing, resetting and adding effects at score milestones
    
    [SerializeField]
    Text scoreText = null; //takes in the text object
    [SerializeField]
    int playerScore = 0; //creates the player score

    [SerializeField]
    steamTrigger steamFunc = null; //takes in an object with the connection to this class
    [SerializeField]
    GameObject steam = null;//steam object

    private void Update(){

        scoreText.text = playerScore.ToString(); //draw the score to the text object as a string

        if(playerScore % 10000 == 0){ //if divisable by 10000
        
            SteamTrigger(); //run function to trigger other class' coroutine
        }
    }

    public void IncreaseScore(int increase){//increases the player score by whatever the entered parameter is
    
        playerScore += increase;
    }
    public void ResetScore(){ //sets the score back to 0
    
        playerScore = 0;
    }

    void SteamTrigger(){ // runs the iemun in steam trigger class
    
       steamFunc.StartCoroutine(steamFunc.steamOn(steam));
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour{ //resets objects and variables to the starting postions

    //takes in all the needed objects and connected scripts
    [SerializeField]
    ScoreManager score =null;
    [SerializeField]
    GameObject springLoc = null;
    [SerializeField]
    GameObject[] resetInactiveObjects = null;
    [SerializeField]
    GameObject entireGameArea = null;
    [SerializeField]
    GameObject entireMenu = null;
    [SerializeField]
    GameObject springDoor = null;
    private void OnTriggerEnter(Collider other){

        score.ResetScore();//resets the score
        springDoor.SetActive(false); //sets the spring door to inactive
        other.transform.position = springLoc.transform.position; //places the ball back to starting position
        foreach(GameObject i in resetInactiveObjects){ //loops through all the inactive objects
        
            i.SetActive(true); //sets them to active
        }
        entireGameArea.SetActive(false); //sets the game area to inactive
        entireMenu.SetActive(true); //activates the menu 

    }

}

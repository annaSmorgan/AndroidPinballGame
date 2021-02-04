using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterTheBrain : MonoBehaviour{//called when the ball enters the brain, opens the exit and closes the entrance

    [SerializeField]
    GameObject[] exitDoors = null; //take all the doors to exit the brain
    [SerializeField]
    GameObject entranceDoor = null;//takes in the entrance
    private void OnTriggerEnter(Collider other){

        if(other.gameObject.tag == "ball"){ //checks if it is the ball
        
            foreach(GameObject i in exitDoors){ //loop through all the gameobjects
            
                i.SetActive(false); //set them to inactive
            }
            
            entranceDoor.SetActive(true); //set the entrance to active
        }
    }
}

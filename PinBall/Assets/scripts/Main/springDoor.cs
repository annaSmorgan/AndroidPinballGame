using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class springDoor : MonoBehaviour{ //sets a wall to active when the ball hits the trigger so that it cant go back down the spring tube

    //takes in all the needed objects
    [SerializeField]
    GameObject door = null;
    private void OnTriggerEnter(Collider other){

        if(other.gameObject.tag == "ball"){//checks if its the ball
            door.SetActive(true); //sets the door to active
        }
    }
}

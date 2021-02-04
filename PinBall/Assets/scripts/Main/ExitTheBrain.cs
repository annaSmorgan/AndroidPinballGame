using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitTheBrain : MonoBehaviour{ //closes the exits to the brain area once the ball has left

    [SerializeField]
    GameObject[] exitDoors = null; //array full of the objects classed as the brain exit
    private void OnTriggerEnter(Collider other){

        if (other.gameObject.tag == "ball"){ //checks if its the ball
        
            foreach(GameObject i in exitDoors){ //loops through all objects in array
            
                i.gameObject.SetActive(true); //sets them to true
            }
            
        }
    }
}

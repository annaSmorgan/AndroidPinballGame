using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningBrain : MonoBehaviour{//checks if both screws have been hit by the ball to then open the brain area for 25 seconds

    //takes in all the needed objects
    [SerializeField]
    GameObject[] screws = null;
    [SerializeField]
    GameObject brainDoor = null;

    private void Update(){

       if(screws[0].activeSelf == false && screws[1].activeSelf == false){ //checks if both screws are inactive
        
            StartCoroutine(DoorOpenLength(brainDoor)); //start the ienumorator
        }
    }

    IEnumerator DoorOpenLength(GameObject door){

        door.SetActive(false); //sets door to inactive

        yield return new WaitForSeconds(25f); //for 25 seconds

        door.SetActive(true); //sets it back to active
        foreach(GameObject i in screws){ //loops through the objects in screws array
        
            i.SetActive(true); //sets them all to active
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class steamTrigger : MonoBehaviour{ //script for setting a steam effect to active for a set time

    [SerializeField]
    GameObject steam = null; //steam object
   
    private void OnTriggerEnter(Collider other){

        if(other.tag == "ball"){ //checks if ball
        
            StartCoroutine(steamOn(steam)); //starts ienumorator
        }
    }
    public IEnumerator steamOn(GameObject steam){
        
        steam.SetActive(true); //sets object to active

        yield return new WaitForSeconds(1.5f); //for 1.5 seconds
            
        steam.SetActive(false); //then sets to inactive again
    }
}

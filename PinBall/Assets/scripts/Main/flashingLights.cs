using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashingLights : MonoBehaviour{ //script to create a flashing light effect 

    [SerializeField]
    GameObject lightSource = null; //inactive light object
    private void OnTriggerEnter(Collider other){

        if (other.tag == "ball"){ //checks if the ball
        
            StartCoroutine(LightFlash(lightSource)); //starts the ienumorator
        }
    }
    public IEnumerator LightFlash(GameObject lightSource){

        lightSource.SetActive(true);//sets the light to active

        yield return new WaitForSeconds(1.0f); //for only a second

        lightSource.SetActive(false); //then sets it to inactive again
    }

}

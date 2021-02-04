using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockingFeaturesCheck : MonoBehaviour{ //checks if both keys were hit, flashes light, then moves onto next feature

    //gameobjects and script connections
    [SerializeField]
    GameObject[] keys = null;
    [SerializeField]
    GameObject lightSource = null;
    [SerializeField]
    GameObject[] tubes = null;
    [SerializeField]
    CommentScript comment = null;
    void Update(){
        
        if (keys[0].activeSelf == false && keys[1].activeSelf == false){//checks if theyre both set to inactive
        
            StartCoroutine(flash(lightSource));//starts the ienumurator
            comment.Tubes(); //sends a new comment
            foreach(GameObject i in tubes){

                i.SetActive(true);//sets the next feature to active
            }
           
        }
    }
    public IEnumerator flash(GameObject lightSource){//shows a light for a second
    
        lightSource.SetActive(true);

        yield return new WaitForSeconds(1.0f);

        lightSource.SetActive(false);
    }
}

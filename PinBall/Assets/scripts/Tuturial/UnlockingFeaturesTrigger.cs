using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockingFeaturesTrigger : MonoBehaviour{ //setting the key to inactive if hit

    [SerializeField]
    CommentScript comment = null; //connection to comment script

    private void OnTriggerEnter(Collider other){

        this.gameObject.SetActive(false);//setting to inactive
        comment.Unlock();//changes comment 
    }
}

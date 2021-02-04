using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipAchieved : MonoBehaviour{ //checks if the player has used the flippers then moving to next challange

    [SerializeField]
    GameObject bouncer = null; //takes in the hidden bouncer
    [SerializeField]
    CommentScript comment = null; //takes a connect to comment manager
    private void OnTriggerEnter(Collider other){

        if(other.gameObject.tag == "ball"){ //checks if the ball
        
            bouncer.SetActive(true); //set the bouncer to active
            comment.FlipAchievedComment();//tell the manager to display the correct comment
        }

    }
}

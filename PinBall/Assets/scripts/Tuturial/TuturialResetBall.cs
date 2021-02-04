using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuturialResetBall : MonoBehaviour{//script for resetting the balls positon once if goes passed the flippers

    [SerializeField]
    GameObject springLoc = null; //gets the location of the spring
    [SerializeField]
    CommentScript comment = null; //gets a connection to comment manager

    private void OnTriggerEnter(Collider other){

        other.transform.position = springLoc.transform.position; //sets the ball to the postion of the spring
        comment.Fail(); //runs the fail comment function
    }
}

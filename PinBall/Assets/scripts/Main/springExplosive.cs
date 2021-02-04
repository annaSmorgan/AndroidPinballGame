using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class springExplosive : MonoBehaviour{//script for forcing the ball from the starting tube into the main area

    float explosiveForce = 400; //force the ball is pushed with
    float explosiveRadius = 5; //radius of the force
    [SerializeField]
    GameObject ball = null; //ball object

    // Update is called once per frame
    void Update(){
        for (int i = 0; i < Input.touchCount; i++){ //loops through the touches to the screen
        
            Touch touch = Input.touches[i]; //sets the touch array to a touch struct
            switch (touch.phase){ //switch on touch phase
            
                case TouchPhase.Began: //on tap
                    spring();
                    break; 
                case TouchPhase.Moved: //on move
                    spring();
                    break;
                case TouchPhase.Stationary: //on hold
                    spring();
                    break;
                case TouchPhase.Ended: //on remove
                    break;
                case TouchPhase.Canceled: //on no touch
                    break;

            }
        }       
    }

    private void spring(){

        Rigidbody r = ball.GetComponent<Rigidbody>();//get the balls rigidbody
        r.AddExplosionForce(explosiveForce, transform.position, explosiveRadius, 0, ForceMode.Impulse); //apply the force to the balls rigidbody
    }

}

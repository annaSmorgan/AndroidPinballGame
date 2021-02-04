using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosiveForce : MonoBehaviour{//applies a force from an object to the ball only when the ball makes contact

    public float appliedForce = 0; //the amount of force
    public float radius = 0; //the area the force is applied 

    bool isFuseLit = false; //bool to see if in contact or not

    [SerializeField]
    GameObject ball = null; //ball game object

    void Update(){
        if (isFuseLit) { // if the fuse is lit

             Bounce(); //run function
        }
    }

    private void Bounce(){
        Rigidbody r = ball.GetComponent<Rigidbody>();//find rigidbody of ball
        r.AddExplosionForce(appliedForce, transform.position, radius, 0, ForceMode.VelocityChange); //apply a velocity change force to the ball by the set force and radius
    }

    private void OnTriggerEnter(Collider other){//using bools to check whether bool is in contact and disable the force if its not
    
        isFuseLit = true;
    }
    private void OnTriggerExit(Collider other){ 
    
        isFuseLit = false;
    }
}
    
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleBouncer : MonoBehaviour{//simple version of the explosiove force script from main

    public float appliedForce = 0;//force
    public float radius = 0; //radius of force

    [SerializeField]
    GameObject ball = null; //ball object

    private void Bounce(){

        Rigidbody r = ball.GetComponent<Rigidbody>();//gets the balls rigidbody
        r.AddExplosionForce(appliedForce, transform.position, radius, 0, ForceMode.VelocityChange);//applies the force to the rigidbody
    }

    private void OnTriggerEnter(Collider other){//runs the bounce function if triggered
    
        Bounce();
    }
   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class liverForce : MonoBehaviour{//moving the ball in a upward direction with force when it enters the tunnel/liver

    private void OnTriggerEnter(Collider other){

        other.GetComponent<Rigidbody>().AddForce(0, 1000, 0, ForceMode.Impulse); //use the impluse force in a upward direction on the rigidbody of ball
    }
}

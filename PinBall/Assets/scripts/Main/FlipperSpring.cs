using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperSpring : MonoBehaviour{//the control of the flippers

    public float restPos = 0.0f; //position when not moving 
    public float maxPos = 53.0f;  //furtherest position glipper can go
    public float force = 10000.0f; //force of which flipper give off and move with
    public float flipperDamper = 150f; //damper for the flipper force
    HingeJoint hinge;//creates a hinge

    void Start(){
        hinge = GetComponent<HingeJoint>(); //sets  to an actual hinge joint
        hinge.useSpring = true; //set it to use spring
    }

    void Update(){

        JointSpring spring = new JointSpring(); //create a new spring joint
        spring.spring = force; //set the spring to the force
        spring.damper = flipperDamper; //set the spring damper to the flipper damper

        for (int i = 0; i < Input.touchCount; i++){ //loop through touches
        
            Touch touch = Input.touches[i]; //set the array of touches as a touch struct
            switch (touch.phase){//switch the touch phases
            
                case TouchPhase.Began:
                    spring.targetPosition = maxPos; //tapped then move to make by the spring force
                    break;
                case TouchPhase.Moved:
                    spring.targetPosition = maxPos;//moved finger then move to make by the spring force
                    break;
                case TouchPhase.Stationary:
                    spring.targetPosition = maxPos;//held then move to make by the spring force
                    break;
                case TouchPhase.Ended:
                    spring.targetPosition = restPos;//removed then move to make by the spring force
                    break;
                case TouchPhase.Canceled:
                    spring.targetPosition = restPos;//not touching then move to make by the spring force
                    break;
            }
        }

        hinge.spring = spring; //set the hinge spring to the spring joint
        hinge.useLimits = true; //give limits
    }
}

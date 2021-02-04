using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TubeCompleted : MonoBehaviour{ //once the ball goes through the tube reset the level and tell the back to menu script to run

    //takes in all the needed objects and connected scripts
    [SerializeField]
    FullReset reset = null;
    [SerializeField]
    CommentScript comment = null;
    [SerializeField]
    GameObject tuturialAreaTwo = null;
    [SerializeField]
    GameObject tuturialAreaOne = null;
    
    public bool called = false; //bool which checks if trigger was triggered to alert the back to menu script

    private void OnTriggerEnter(Collider other){

        other.GetComponent<Rigidbody>().AddForce(0, 10, 0, ForceMode.Impulse); //adds a upwards force to the ball
        StartCoroutine(BeforeTuturialChange());//start ienumurator
        called = true; //set to true which starts the back to mneu script
    }

    IEnumerator BeforeTuturialChange(){//show the last comment for 5 seconds before resetiing level and moving to the menu
    
        comment.CompleteAll();

        yield return new WaitForSeconds(7f);

        reset.Reset();
        tuturialAreaOne.SetActive(true);
        tuturialAreaTwo.SetActive(false);
       
    }
}

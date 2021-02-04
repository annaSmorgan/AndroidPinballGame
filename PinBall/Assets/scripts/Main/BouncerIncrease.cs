using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncerIncrease : MonoBehaviour{//script for adding to the score depending on what object its hit

    //takes in all the needed connected scripts
    [SerializeField]
    ScoreManager score = null;

    private void OnTriggerEnter(Collider other){ //checks the object being hits tag

        if(this.gameObject.tag == "nerve"){
            NerveIncrease();
        }
        else if (this.gameObject.tag == "bone"){
            BoneIncrease();
        }
        else if (this.gameObject.tag == "kidney"){
            KidneyIncrease();
        }
        else if (this.gameObject.tag == "brain"){
            BrainWallIncrease();
        }
    }
    //all functions add a different amount to the score by calling the increase function from score manager
    void NerveIncrease(){
        score.IncreaseScore(2000);
    }
    void BoneIncrease(){
        score.IncreaseScore(1000);
    }
    void KidneyIncrease(){
        score.IncreaseScore(1500);
    }
    void BrainWallIncrease(){
        score.IncreaseScore(20);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrewRemoval : MonoBehaviour{//sets the screw as inactive and increases the score once the ball hits it

    //takes in all the needed connected scripts
    [SerializeField]
    ScoreManager score = null;
    private void OnTriggerEnter(Collider other){

        this.gameObject.SetActive(false);//sets screw to inactive
        score.IncreaseScore(500); //increases score by 500
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour{ //script for returning to the main scene 

    [SerializeField]
    TubeCompleted tube = null; //takes in the object containing the needed script
    void Update(){

        if(tube.called == true){ //checks if the class was called by checking if the bool is true
        
            SceneManager.LoadScene("SampleScene"); //changing to the main scene
        }
    }
}

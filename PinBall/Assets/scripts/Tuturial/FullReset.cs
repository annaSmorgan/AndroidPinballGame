using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullReset : MonoBehaviour{ //resets each tuturial back to starting postion once the player moves on

    //taking in all the needed objects and connected scripts 
    [SerializeField]
    GameObject springLoc = null;
    [SerializeField]
    GameObject ball = null;
    [SerializeField]
    GameObject[] inactiveObjects = null;
    [SerializeField]
    GameObject[] activeObjects = null;
    [SerializeField]
    CommentScript comment = null;

    public void Reset(){

        ball.transform.position = springLoc.transform.position;//sets the ball to the correct postion
        foreach(GameObject active in activeObjects){ //checks through active objects setting to inactive
        
            active.SetActive(false);
        }
        foreach (GameObject inactive in inactiveObjects){//checks through inactive objects setting to active
        
            inactive.SetActive(true);
        }
        if(this.tag == "tuturial1"){//if the first tuturial
        
            comment.ResetText1();//reset to the comment for the first tuturial
        }
        else if(this.tag == "tuturial2"){//if the second tuturial
        
            comment.ResetText2();//reset to the comment for the first tuturial
        }
    }
}

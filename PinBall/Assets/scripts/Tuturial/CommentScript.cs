using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CommentScript : MonoBehaviour{//script which handles all the text being shown during the tuturials

    [SerializeField]
    Text mainCommentArea = null; //takes in the text object
    [SerializeField]
    Text commentArea = null; //takes in the text object

    public void Fail(){

        StartCoroutine(FailCommentTime()); //start the ienumerator
    }
    IEnumerator FailCommentTime(){ //shows the fail comment for 5 seconds before showing blank
    
        commentArea.text = "It's okay, Try Again";

        yield return new WaitForSeconds(5f);

        commentArea.text = null;
    }

    public void FlipAchievedComment(){ //edits the main text to give the second instruction
    
        mainCommentArea.text = "Good! Now try hitting the bouncer";
    }
    public void Complete(){ //edits the main text to tell the player the level is moving on
    
        mainCommentArea.text = "Well Done! To the Next Stage";
    }
    public void CompleteAll(){ //edits the main text to tell the player its going back to the menu
    
        mainCommentArea.text = "Well Done! Thats the tuturials done!";
    }
    public void ResetText1(){//sets text back to original text
    
        mainCommentArea.text = "Tap to launch the ball Then tap to use flippers";
    }
    public void ResetText2(){//sets text back to original text tuturial 2
    
        mainCommentArea.text = "Some objects need to be hit to unlock stuff!";
    }
    public void Unlock(){//shows encourage meant when a key is triggered
    
        StartCoroutine(UnlockLength());
    }
    IEnumerator UnlockLength(){ //shows the comment for 5 seconds before showing blank
    
        commentArea.text = "Thats It!";

        yield return new WaitForSeconds(3f);

        commentArea.text = null;
    }
    public void Tubes(){ //tells the player the next instruction
    
        mainCommentArea.text = "Now Try to go through the tube for a boost!";
    }
}

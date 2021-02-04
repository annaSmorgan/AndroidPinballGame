using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceAchieved : MonoBehaviour{//moves onto the next tuturial area 

    //takes in all the needed objects and connected scripts
    [SerializeField]
    GameObject tuturialOneArea = null;
    [SerializeField]
    GameObject tuturialTwoArea = null;
    [SerializeField]
    FullReset reset = null;
    [SerializeField]
    CommentScript comment = null;

    private void OnTriggerEnter(Collider other){

        StartCoroutine(BeforeTuturialChange());//start ienumurator
    }

    IEnumerator BeforeTuturialChange(){//show the last comment for 5 seconds before resetiing level and moving to next
    
        comment.Complete(); 

        yield return new WaitForSeconds(5f);

        reset.Reset();
        tuturialOneArea.SetActive(false);
        tuturialTwoArea.SetActive(true);
    }
}

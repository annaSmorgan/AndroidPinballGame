using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SplashScreen : MonoBehaviour{//script for the splash screen, making it play for 5 seconds before mobing to next scene

    void Start(){

        StartCoroutine(ToMenu()); //start the ienumorator
    }

    IEnumerator ToMenu(){//IEmumerator to iterate after 5 seconds

        yield return new WaitForSeconds(5.0f);//waits 5 seconds
        SceneManager.LoadScene(1);//loads scene labelled as 1 or the main scene containing the menu
    }
}

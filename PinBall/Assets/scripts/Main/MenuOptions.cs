using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuOptions : MonoBehaviour{//controls the menu, settings and scene changes 

    //takes in all the needed objects
    public GameObject playArea;
    public GameObject settingArea;
    public GameObject door;
    public Slider brightness;
    public Light lightSource;

    public void StartPlay(){

        this.gameObject.SetActive(false); //sets menu to inactive
        playArea.SetActive(true); //sets the game envirnment to active
    }
    public void Settings(){

        this.gameObject.SetActive(false); //sets menu to inactive
        settingArea.SetActive(true); //sets the settinfs to active
    }
    public void SettingsBack(){

        this.gameObject.SetActive(true); //sets menu to active
        settingArea.SetActive(false); //sets the settings to inactive
    }

    public void ChangeToScene(string sceneName){//brings in a string of the scene name
    

        SceneManager.LoadScene(sceneName);//loads the scene listed in parameter
    }

    public void QuitGame(){

        Application.Quit();//quits the application
    }
    public void Brightness(){

        lightSource.intensity = brightness.value; //sets the light intentisy of the main light in the game area to the value of the slider
    }

}

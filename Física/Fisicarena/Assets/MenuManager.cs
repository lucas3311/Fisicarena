using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class MenuManager : MonoBehaviour
{
    void Start() {
        Screen.SetResolution(960, 540, false);
    }
    // Use this for initialization
    public void StartPlay() {
        SceneManager.LoadScene(1);
    }

    public void Quit () {
        Application.Quit();
	}

}

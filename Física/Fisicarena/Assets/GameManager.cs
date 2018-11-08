using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public int Score1 = 0;
    public int Score2 = 0;
    public int PlacarMaximo = 10;
    public Text Placar1;
    public Text Placar2;

    public int phase;

    public GameObject Level1;
    public GameObject Level2;
    public GameObject Level3;

    public GameObject WinningScreen;
    public Text WinningText;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Placar1.text = Score1.ToString();
        Placar2.text = Score2.ToString();
        if (phase == 0) {
            Level1.SetActive(true);
            Level2.SetActive(false);
            Level3.SetActive(false);
        }
        if (phase == 1)
        {
            Level1.SetActive(false);
            Level2.SetActive(true);
            Level3.SetActive(false);
        }
        if (phase == 2)
        {
            Level1.SetActive(false);
            Level2.SetActive(false);
            Level3.SetActive(true);
        }
        if (Score1 == PlacarMaximo) {
            Win("Player1 Wins!");
        }
        if (Score2 == PlacarMaximo)
        {
            Win("Player2 Wins!");
        }
        if (phase == 3)
        {
            phase = 0;
        }
        Debug.Log(phase);
    }
    void Win(string texto) {
        Time.timeScale = 0.0f;
        WinningScreen.SetActive(true);
        WinningText.text = texto;
    }
    public void GoToMenu() {
        SceneManager.LoadScene(0);
    }
}

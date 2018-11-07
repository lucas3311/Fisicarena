using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public int Score1 = 0;
    public int Score2 = 0;
    public Text Placar1;
    public Text Placar2;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Placar1.text = Score1.ToString();
        Placar2.text = Score2.ToString();
	}
}

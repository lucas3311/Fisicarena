using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public int Score1 = 0;
    public int Score2 = 0;
    public Text Placar1;
    public Text Placar2;

    public int phase;

    public GameObject Level1;
    public GameObject Level2;
    public GameObject Level3;

    public GameObject Player1;
    public GameObject Player2;
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
    }
    public IEnumerator WaitToSpawn(float waitTime)
    {
        Debug.Log("Begin");
        yield return new WaitForSeconds(waitTime);
        Instantiate(Player1, new Vector3(-7.64f, 0, -0.01953382f), Quaternion.identity);
        Instantiate(Player2, new Vector3(7.64f, 0, -0.02f), Quaternion.identity);
    }
}

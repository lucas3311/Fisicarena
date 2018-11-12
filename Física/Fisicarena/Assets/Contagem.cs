using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contagem : MonoBehaviour {
    float timeLeft = 3.4f;
    public Text contagem;
    public GameObject Panel;

    public GameObject Player1;
    public GameObject Player2;

    public Animator FadeOut;
    // Use this for initialization
    void Start () {
        Player1.GetComponent<Boot>().enabled = false;
        Player2.GetComponent<Boot1>().enabled = false;

    }

    // Update is called once per frame
    void Update () {
        FadeOut.Play("Fade out");
        timeLeft -= Time.deltaTime;
        contagem.text = Mathf.Round(timeLeft).ToString();
        if (timeLeft <= 0) {
            Panel.SetActive(false);
            Player1.GetComponent<Boot>().enabled = true;
            Player2.GetComponent<Boot1>().enabled = true;

        }

    }
  
}

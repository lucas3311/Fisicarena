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

    public AudioSource audio;
    public AudioSource audio2;


    bool cont3 = true;
    bool cont2 = true;
    bool cont1 = true;
    bool cont0 = true;

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

        if (Mathf.Round(timeLeft) == 3 && cont3) {
            audio.PlayOneShot(audio.clip, 1);
            cont3 = false;
        }
        if (Mathf.Round(timeLeft) == 2 && cont2)
        {
            audio.PlayOneShot(audio.clip, 1);
            cont2 = false;

        }
        if (Mathf.Round(timeLeft) == 1 && cont1)
            {
                audio.PlayOneShot(audio.clip, 1);
            cont1 = false;

        }
        if (Mathf.Round(timeLeft) == 0 && cont0)
        {
            audio.PlayOneShot(audio2.clip, 1);
            cont0 = false;

        }


        if (timeLeft <= 0) {
            Panel.SetActive(false);
            Player1.GetComponent<Boot>().enabled = true;
            Player2.GetComponent<Boot1>().enabled = true;

        }

    }
  
}

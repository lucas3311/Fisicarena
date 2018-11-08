using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boot : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Shoot>().enabled = true;
        gameObject.GetComponent<CircleCollider2D>().enabled = true;
    }

    // Update is called once per frame
    void Update () {
		
	}
}

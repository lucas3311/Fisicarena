using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boot1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Shoot1>().enabled = true;
        gameObject.GetComponent<CircleCollider2D>().enabled = true;
    }

    // Update is called once per frame
    void Update () {
		
	}
}

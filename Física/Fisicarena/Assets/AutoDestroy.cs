using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(destroy());
	}

    private IEnumerator destroy() {
        yield return new WaitForSeconds(3);
            Destroy(gameObject);
    }
}

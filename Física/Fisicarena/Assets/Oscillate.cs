using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillate : MonoBehaviour {

    public float maxValue = 15; // or whatever you want the max value to be
    public float minValue = -15; // or whatever you want the min value to be
    float currentValue = 0; // or wherever you want to start
    float direction = 2;


    void Update()
    {
        currentValue += Time.deltaTime * direction; // or however you are incrementing the position
        if (currentValue >= maxValue)
        {
            direction *= -1;
            currentValue = maxValue;
        }
        else if (currentValue <= minValue)
        {
            direction *= -1;
            currentValue = minValue;
        }
        transform.position = new Vector3(0, currentValue, 0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_6 : MonoBehaviour
{
    // Distance traveled and to be traveled

    public float distanceTraveled;
    public float distanceToBeTraveled;

    private float result;

    private void Start()
    {
        result = distanceToBeTraveled - distanceTraveled;

        if (distanceTraveled > distanceToBeTraveled)
        {
            Debug.Log($"Congratulations! You have completed the total distance.");
        }
        if (distanceTraveled < distanceToBeTraveled)
        {
            Debug.Log($"Oh... you have {result} meters left  to complete the total distance.");
        }
    }


}

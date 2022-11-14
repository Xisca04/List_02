using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_1 : MonoBehaviour
{
    //Positive-Negative-Zero

    public float number;

    private void Start()
    {
        if(number == 0)
        {
            Debug.Log($"This number, {number}, is zero.");
        }
        else if(number < 0)
        {
            Debug.Log($"This number, {number}, is negative.");
        }
        else
        {
            Debug.Log($"This number, {number}, is positive.");
        }
    }
}

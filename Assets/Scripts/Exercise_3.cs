using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_3 : MonoBehaviour
{
    // Number is divisble by 5
   
    public int number;
    private int number2 = 5;
    private int result;

    private void Start()
    {
        result = number / number2;
        Debug.Log($"This number, {number}, is divisible by 5, the result is {result}.");

    }
}

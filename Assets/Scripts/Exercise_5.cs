using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_5 : MonoBehaviour
{
    //Legal age or not

    public int age;

    private void Start()
    {
        if(age > 17)
        {
            Debug.Log($"Hello, you are {age} years old, so you are of legal age.");
        }
        else
        {
            Debug.Log($"Hello, you are {age} years old, so you are not of legal age.");
        }
    }
}

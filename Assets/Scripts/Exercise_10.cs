using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_10 : MonoBehaviour
{
    // The year is a leap year

    public int year;
    private int result;
    
    
    private void Start()
    {
        result = year / 4;
        {
            Debug.Log($"The year {year} is a leap year");
        }

        result = year !/ 100;
        {
            Debug.Log($"The year {year} is not a leap year");
        }
    } 
}

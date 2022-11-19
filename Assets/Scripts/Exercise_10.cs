using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_10 : MonoBehaviour
{
    // The year is a leap year

    public int year;
    

    private void Start()
    {
        year /= 4;
        {
            Debug.Log($"The year {year} is a leap year");
        }

        
    }

    
}

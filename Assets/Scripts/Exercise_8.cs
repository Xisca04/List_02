using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_8 : MonoBehaviour
{
    // Total points

    public int points;

    private void Start()
    {
        if (points > 100)
        {
            Debug.Log($"You have more than 100 points.");
        }

        if (points <= 100 , > 75)
        {
            Debug.Log($"You have more than 75 points, but less than or equal to 100.");
        }

        if (points <= 75 , > 50)
        {
            Debug.Log($"You have more than 50 points, but less than or equal to 75.");
        }

        if (points <= 50 , > 25)
        {
            Debug.Log($"You have more points than 25, but less than or equal to 50.");

        }else{

            Debug.Log($"You have less than or equal to 25 points.");
        }
        

       
    }
}

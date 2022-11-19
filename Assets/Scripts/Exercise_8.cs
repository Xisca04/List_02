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
            Debug.Log($"You have more than 100 points!");
        }
        else
        {
            if(points >= 75)
            {
                Debug.Log($"You have more than 75 points, but less than or equal to 100 points.");
            }
            else
            {
                Debug.Log($"You have more than 50 points, but less than or equal to 75 points.");
            }
        }

        if (points >= 50)
        {
            Debug.Log($"You have more than 25 points, but less than or equal to 50 points.");
        }
        else
        {
            Debug.Log($"You have lees than or equal to 25 points.");
        }

    }
}

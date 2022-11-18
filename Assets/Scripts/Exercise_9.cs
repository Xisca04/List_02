using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_9 : MonoBehaviour
{
    //Vegetarian option

    public bool wantsVegetarianOption;

    private void Start()
    {
        if (!wantsVegetarianOption)
        {
            Debug.Log($"Non-vegetarian option coming soon.");
        }
        else
        {
            Debug.Log($"Vegetarian option coming soon.");
        }
    }


}

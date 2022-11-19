using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_7 : MonoBehaviour
{
   //Sum, subtraction, product and division

    public string operation;
    public float x;
    public float y;

    private void Start()
    {
       if (operation == "sum")
       {
            Debug.Log($"Sum: {x} + {y} = {x + y}");
       }
       
       if (operation == "subtraction")
        {
            Debug.Log($"Subtraction: {x} - {y} = {x - y}");
        }

       if (operation == "product")
        {
            Debug.Log($"Product: {x} * {y} = {x * y}");
        }

       if (operation == "division")
        {
            Debug.Log($"Division: {x} / {y} = {x / y}");
        }
    }
}

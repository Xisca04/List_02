using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_4 : MonoBehaviour
{
    //The area of a triangle

    public float Base;
    public float height;
    private float result;

    private void Start()
    {
        result = (Base * height) / 2;

        if ((Base * height) > 0)
        {
            Debug.Log($"The area of the triangle, {result}, has the base {Base} and the height {height}.");
        }
        else
        {
            Debug.Log($"The area of the triangle can not be calculated.");
        }
    }
}

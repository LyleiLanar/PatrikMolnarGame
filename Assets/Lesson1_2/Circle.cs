using System;
using UnityEngine;

public class Circle : MonoBehaviour
{
    [SerializeField] float radius;

    [SerializeField] float input1, input2;
    [SerializeField] float power, absolute, sign, rounded, ceiled, floor, min, sqrt;

    void Start()
    {
        Debug.Log("Radius: " + radius);
        Debug.Log("Kerület: " + 2 * Mathf.PI * radius);
        Debug.Log("Terület: " + Mathf.Pow(radius, 2) * Math.PI);
    }

    private void OnValidate()
    {
        power = Mathf.Pow(input1, input2);
        absolute = Mathf.Abs(input1);
        sign = Mathf.Sign(input1);
        rounded = Mathf.Round(input1);
        ceiled = Mathf.Ceil(input1);
        floor = Mathf.Floor(input1);
        min = Mathf.Min(input1, input2);
        sqrt = Mathf.Sqrt(input1);
    }
}

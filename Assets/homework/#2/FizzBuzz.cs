using System.Collections.Generic;
using UnityEngine;

public class FizzBuzz : MonoBehaviour
{
    [SerializeField] int number;
    [SerializeField] List<string> results;

    private void OnValidate()
    {
        results.Clear();

        for (int i = 1; i <= number; i++)
        {

            if (i % 15 == 0)
            {
                results.Add("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                results.Add("Fizz");
            }
            else if (i % 5 == 0)
            {
                results.Add("Buzz");
            }
            else
            {
                results.Add(i.ToString());
            }
        }
    }
}

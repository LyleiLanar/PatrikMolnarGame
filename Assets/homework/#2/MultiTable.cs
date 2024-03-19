using System.Collections.Generic;
using UnityEngine;

public class MultiTable : MonoBehaviour
{
    [SerializeField] int number;
    [SerializeField] List<string> results;

    private void OnValidate()
    {
        results.Clear();

        for (int i = 1; i <= number; i++)
        {
            for (int j = 1; j <= number; j++)
            {
                results.Add($"{j} * {i} = {j * i}");
            }
        }
    }
}

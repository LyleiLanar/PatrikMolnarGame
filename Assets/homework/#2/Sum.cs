using UnityEngine;

public class Sum : MonoBehaviour
{
    [SerializeField] int number;
    [SerializeField] int sum;
    private void OnValidate()
    {
        int acc = 0;
        for (int i = 1; i <= this.number; i++)
        {
            acc += i;
        }

        sum = acc;
    }
}

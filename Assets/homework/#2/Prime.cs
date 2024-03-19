using UnityEngine;

public class Prime : MonoBehaviour
{
    [SerializeField] int number;
    [SerializeField] bool isPrime;
    private void OnValidate()
    {
        if (number <= 1)
        {
            isPrime = false;
        }
        else
        {
            int i = 2;
            int maxi = number / 2;
            while (i <= maxi && !(number % i == 0))
            {
                i++;
            }
            isPrime = i > maxi;
        }
    }
}

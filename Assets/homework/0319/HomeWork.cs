using System.Collections.Generic;
using UnityEngine;

public class HomeWork : MonoBehaviour
{

    [SerializeField] float value;
    [SerializeField] Vector2 vectorA;
    [SerializeField] Vector2 vectorB;

    [SerializeField] Vector3 vectorC;
    [SerializeField] Vector3 vectorD;

    [SerializeField] float min;
    [SerializeField] float max;
    [SerializeField] float clamp;
    [SerializeField] float clamp01;
    [SerializeField] float floor;
    [SerializeField] float ceiling;
    [SerializeField] float round;
    [SerializeField] List<float> firstNPrime;
    [SerializeField] float distance;
    [SerializeField] Vector3 normalized;

    private void OnValidate()
    {
        firstNPrime.Clear();

        clamp = Clamp(value, min, max);
        clamp = Clamp(value);
        floor = Floor(value);
        ceiling = Ceiling(value);
        round = Round(value);
        firstNPrime = FistNPrime((int)value);
        distance = Distance(vectorA, vectorB);
        normalized = Normalize(Direction(vectorC, vectorD));
    }
    private float Clamp(float value, float min, float max)
    {
        if (value < min) return min;
        if (value > max) return max;
        return value;
    }

    private float Clamp(float value)
    {
        return Clamp(value, 0, 1);
    }

    private float Floor(float number)
    {
        return (int)number;
    }

    private float Ceiling(float number)
    {
        return Floor(number + 1);
    }

    private float Round(float number)
    {
        if (number * 10 % 10 < 5) return Floor(number);
        return Ceiling(number);
    }

    private List<float> FistNPrime(int number)
    {
        List<float> primes = new();

        if (number < 1)
        {
            Debug.LogError("Error! The number is lower than 1...");
        }

        primes.Add(2);

        int found = 1;
        int i = 3;
        while (found < number)
        {
            if (IsPrime(i))
            {
                primes.Add(i);
                found++;
            }
            i++;
        }

        return primes;

    }

    private bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }
        else
        {
            int i = 2;
            int maxi = number / 2;
            while (i <= maxi && !(number % i == 0))
            {
                i++;
            }
            return i > maxi;
        }
    }

    private float Distance(Vector2 a, Vector2 b)
    {
        float dx = b.x - a.x;
        float dy = b.y - a.y;

        return Mathf.Sqrt(dx * dx + dy * dy);
    }

    private float Magnitude(Vector3 vector)
    {

        return Mathf.Sqrt(vector.x * vector.x + vector.y * vector.y + vector.z * vector.z);
    }

    private Vector3 Normalize(Vector3 vector)
    {
        float mangitude = Magnitude(vector);
        return new Vector3(vector.x / mangitude, vector.y / mangitude, vector.z / mangitude);
    }

    private Vector3 Direction(Vector3 a, Vector3 b)
    {
        return new Vector3(b.x - a.x, b.y - a.y, b.z - a.z);
    }
}

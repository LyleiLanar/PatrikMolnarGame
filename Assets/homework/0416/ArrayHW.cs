using UnityEngine;

public class ArrayHW : MonoBehaviour
{

    [SerializeField] float[] MyArray = new float[] { 1, 2, 3, 4, 5 };
    [SerializeField] float[] ReversedArray;
    [SerializeField] float Avg;
    [SerializeField] float Min;
    [SerializeField] float Max;
    [SerializeField] int N = 4;
    [SerializeField] int FibonacciElement;
    [SerializeField] int[] FibonacciArray;
    private void OnValidate()
    {
        Avg = CalculateAverage(MyArray);
        Min = GetMinimum(MyArray);
        Max = GetMaximum(MyArray);

        ReversedArray = (float[])MyArray.Clone();
        MakeItReversed(ReversedArray);

        FibonacciElement = Fibonacci(N);
        FibonacciArray = new int[N];
        for (int i = 0; i < N; i++)
        {
            FibonacciArray[i] = Fibonacci(i + 1);
        }
    }

    float CalculateAverage(float[] a)
    {
        float sum = 0;
        for (int i = 0; i < a.Length; i++)
        {
            sum += a[i];
        }

        return sum / a.Length;
    }

    float GetMaximum(float[] a)
    {
        float max = a[0];

        for (int i = 1; i < a.Length; i++)
        {
            if (a[i] > max)
                max = a[i];
        }

        return max;
    }

    float GetMinimum(float[] a)
    {
        float min = a[0];

        for (int i = 1; i < a.Length; i++)
        {
            if (a[i] < min)
                min = a[i];
        }

        return min;
    }

    void MakeItReversed(float[] a)
    {
        for (int i = 0; i <= a.Length / 2; i++)
        {
            int l = a.Length - 1 - i;

            float temp = a[i];
            a[i] = a[l];
            a[l] = temp;
        }
    }

    int Fibonacci(int n)
    {
        if (n <= 1)
            return 0;

        if (n == 2)
            return 1;

        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}

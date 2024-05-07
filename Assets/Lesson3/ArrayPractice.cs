using UnityEngine;

public class ArrayPractice : MonoBehaviour
{
    [SerializeField] int size;
    [SerializeField] string[] numbersString;
    [SerializeField] int[] numbers;
    [SerializeField] int max;
    void OnValidate()
    {
        numbers = new int[size];
        task3();
    }

    private void task1()
    {

        for (int i = 0; i < size; i++)
        {
            numbersString[i] = (size - i).ToString();
        }
    }

    private void task2()
    {
        for (int i = 0; i < size; i++)
        {
            string text = "";

            for (int j = 0; j < i + 1; j++)
            {
                text += (i + 1).ToString();
            }

            numbersString[i] = text;
        }
    }

    private void task3()
    {
        for (int i = 0; i < size; i++)
        {
            numbers[i] = Random.Range(1, 100);
        }

        max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
    }
}

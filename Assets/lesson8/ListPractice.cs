using System.Collections.Generic;
using UnityEngine;

public class ListPractice : MonoBehaviour
{

    [SerializeField]
    List<string> MyList;

    void Start()
    {
        MyList = new();

        MyList.AddRange(new List<string>() { "kacsa", "csirke" });
        MyList.Add("kutya");
        MyList.Insert(3, "malac");

        MyList.Remove("kutya");
        MyList.RemoveAt(0);

        MyList.IndexOf("malac");
        MyList.Contains("muslica");

        MyList.Sort();
        MyList.Reverse();

        MyList.Clear();
    }

    float Mean(List<float> numbers)
    {
        float summa = 0f;

        foreach (float item in numbers)
            summa += item;

        return summa / numbers.Count;
    }
}

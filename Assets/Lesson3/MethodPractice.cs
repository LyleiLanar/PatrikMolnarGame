using UnityEngine;

public class MethodPractice : MonoBehaviour
{

    [SerializeField] int number;
    [SerializeField] int result;
    private void OnValidate()
    {
        result = Abs(number);
    }
    private int Abs(int num)
    {
        return num < 0 ? -num : num;
    }
}

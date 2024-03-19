using UnityEngine;

public class First : MonoBehaviour
{
    [SerializeField] int a;
    [SerializeField] int b;
    [SerializeField] string summaryText;

    private void OnValidate()
    {
        summaryText = $"{a} + {b} = {a + b}";
    }
}

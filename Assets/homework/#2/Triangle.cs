using UnityEngine;

public class Triangle : MonoBehaviour
{
    [SerializeField] int a;
    [SerializeField] int b;
    [SerializeField] int c;
    [SerializeField] string triangle;

    private void OnValidate()
    {
        if (!IsTriangle())
        {
            triangle = "It is a not a triangle at all!";
        }
        else if (!IsRightTriangle)
        {
            triangle = "No it is not a Right Triangle!";
        }
        else
        {
            triangle = "Yeah, it is a Right Triangle!";
        }
    }

    private bool IsTriangle()
    {
        bool onlyPositive = a > 0 && b > 0 && c > 0;
        bool drawable = a + b > c && a + c > b && b + c > a;

        return onlyPositive && drawable;
    }

    private bool IsRightTriangle => (a * a) + (b * b) == (c * c);
}

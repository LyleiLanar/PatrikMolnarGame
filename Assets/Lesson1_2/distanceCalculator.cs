using UnityEngine;

public class distanceCalculator : MonoBehaviour
{
    [SerializeField] Vector2 a;
    [SerializeField] Vector2 b;

    float GetDistance(Vector2 a, Vector2 b)
    {
        float dx = Mathf.Abs(a.x - b.x);
        float dy = Mathf.Abs(a.y - b.y);
        float distance = Mathf.Sqrt(Mathf.Pow(dx, 2) + Mathf.Pow(dy, 2));
        return distance;
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(GetDistance(a, b));
    }
}

using UnityEngine;

public class VectorPractice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector2 v1 = new(2, 3);

        float x1 = v1.x;
        float y1 = v1.y;

        Vector2 v2 = new(2, 3);

        float x2 = v2.x;
        float y2 = v2.y;

        Vector2 vSum = v1 + v2;
        float magnitude = vSum.magnitude;

        Vector2 normalized = vSum.normalized;
    }

    // Update is called once per frame
    void Update()
    {

    }
}

using UnityEngine;

public class Between : MonoBehaviour
{

    [SerializeField] Transform a;
    [SerializeField] Transform b;
    [SerializeField] float ratio;

    void Update()
    {
        Vector3 direction = b.position - a.position;
        transform.position = a.position + (Mathf.Clamp(ratio, 0, 1) * direction);
    }

}

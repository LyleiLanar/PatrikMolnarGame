using UnityEngine;


public class Between : MonoBehaviour
{

    [SerializeField] Transform a;
    [SerializeField] Transform b;
    [SerializeField, Range(0, 1)] float ratio;
    [SerializeField] float speed = 10;

    void Update()
    {
        //Vector3 direction = b.position - a.position;
        //transform.position = a.position + (Mathf.Clamp(ratio, 0, 1) * direction);

        // Ez nem jó.
        //Vector3 sum = a.position + b.position;
        //transform.position = sum * (1 / ratio);

        // Lineráris interpoláció:
        transform.position = ratio * b.position + (1 - ratio) * a.position;

        // Erre van beépített függvény. Ez a LERP.
        //transform.position = Vector3.Lerp(a.position, b.position, ratio);

        transform.position = Vector3.MoveTowards(a.position, b.position, speed * Time.deltaTime);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(a.position, b.position);
    }
}

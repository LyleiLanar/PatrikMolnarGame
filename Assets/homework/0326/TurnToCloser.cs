using UnityEngine;

public class TurnToCloser : MonoBehaviour
{
    [SerializeField] Transform target1;
    [SerializeField] Transform target2;

    void Update()
    {
        float distance1 = Vector2.Distance(target1.position, transform.position);
        float distance2 = Vector2.Distance(target2.position, transform.position);
        Transform closerTarget = distance1 < distance2 ? target1 : target2;

        RotateToward2D_V2(transform.position, closerTarget.position, 360 * Time.deltaTime);
    }

    private void RotateToward2D(Vector2 current, Vector2 target, float maxRadiantDelta)
    {
        Vector2 direction = (target - current).normalized;
        float zRotation = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0f, 0f, zRotation - 90), maxRadiantDelta);
    }

    private void RotateToward2D_V2(Vector2 current, Vector2 target, float maxRadiantDelta)
    {
        Vector2 direction = (target - current);
        Quaternion to = Quaternion.LookRotation(Vector3.forward, direction);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, to, maxRadiantDelta);
    }

}

using UnityEngine;

public class TurnToCloser : MonoBehaviour
{
    [SerializeField] Transform target1;
    [SerializeField] Transform target2;

    void Update()
    {
        float distanceTarget1 = Vector2.Distance(target1.position, transform.position);
        float distanceTarget2 = Vector2.Distance(target2.position, transform.position);
        Transform closerTarget = distanceTarget1 < distanceTarget2 ? target1 : target2;

        RotateToward2D(transform.position, closerTarget.position, 360 * Time.deltaTime);
    }

    private void RotateToward2D(Vector2 current, Vector2 target, float maxRadiantDelta)
    {
        Vector2 direction = (target - current).normalized;
        float zRotation = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0f, 0f, zRotation - 90), maxRadiantDelta);
    }

}

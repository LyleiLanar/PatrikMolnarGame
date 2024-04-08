using UnityEngine;

public class Escape : MonoBehaviour
{
    [SerializeField] Transform enemy;
    [SerializeField] float minDistance;
    [SerializeField] float acceleration;
    [SerializeField] float maxSpeed;
    private float speed;
    private Vector3 escapingVector;

    public bool IsPaniced
    {
        get
        {
            float distanceFromEnemy = Vector3.Distance(transform.position, enemy.position);
            return distanceFromEnemy < minDistance;
        }
    }

    void Update()
    {

        if (IsPaniced)
        {
            speed += acceleration * Time.deltaTime;
            escapingVector = (transform.position - enemy.position).normalized;
        }
        else
        {
            speed -= acceleration * Time.deltaTime;
        }

        speed = Mathf.Clamp(speed, 0, maxSpeed);
        transform.position = Vector3.MoveTowards(transform.position, transform.position + escapingVector, speed * Time.deltaTime);

        LookForward();
    }

    private void LookForward()
    {
        if (transform.position.x - (transform.position + escapingVector).x > 0)
        {
            transform.rotation = new Quaternion(0, 180, 0, 0);
        }
        else
        {
            transform.rotation = new Quaternion(0, 0, 0, 0);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, minDistance);
    }
}

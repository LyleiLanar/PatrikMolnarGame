using UnityEngine;

public class Stepping : MonoBehaviour
{

    [SerializeField] private float stepSize = 1f;
    [SerializeField] private float speed = 3f;
    private Vector3 targetLocation;

    private void Start()
    {
        targetLocation = transform.position;
    }

    void Update()
    {
        StepWithSpeed();
    }

    private void StepWithSpeed()
    {
        if (Input.anyKeyDown && transform.position == targetLocation)
        {
            Vector3 direction = GetDirection();

            targetLocation = transform.position + direction;
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, targetLocation, speed * Time.deltaTime);
            if (transform.position.x - targetLocation.x > 0)
            {
                transform.rotation = new Quaternion(0, 180, 0, 0);
            }
            else
            {
                transform.rotation = new Quaternion(0, 0, 0, 0);
            }
        }
    }

    private void Step()
    {
        if (Input.anyKeyDown)
        {
            Vector3 direction = GetDirection();
            transform.position += direction * stepSize;
        }
    }

    private Vector3 GetDirection()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(x, y).normalized;

        return direction;
    }
}

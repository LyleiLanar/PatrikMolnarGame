using UnityEngine;

public class Follow : MonoBehaviour
{
    [SerializeField] private Transform toCatch;
    [SerializeField] private float speed;
    [SerializeField] private float standoff;

    void Update()
    {
        Vector3 targetPosition = toCatch.position;
        Vector3 myPosition = transform.position;
        float distanceFromTarget = (targetPosition - myPosition).magnitude;

        if (distanceFromTarget > standoff)
        {

            transform.position = Vector3.MoveTowards(myPosition, targetPosition, speed * Time.deltaTime);

            if (myPosition.x - targetPosition.x > 0)
            {
                transform.rotation = new Quaternion(0, 180, 0, 0);
            }
            else
            {
                transform.rotation = new Quaternion(0, 0, 0, 0);
            }
        }
    }
}

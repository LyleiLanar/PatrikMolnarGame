using UnityEngine;

public class HomingMissle : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float speed = 1f;
    [SerializeField] float angularVelocity = 360;

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, transform.position + transform.up, speed * Time.deltaTime);

        Quaternion rotation = Quaternion.LookRotation(target.position - transform.position) * Quaternion.Euler(90, 0, 0);
        //Quaternion rotation = Quaternion.LookRotation(target.position - transform.position, Vector3.up);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, angularVelocity * Time.deltaTime);
    }
}

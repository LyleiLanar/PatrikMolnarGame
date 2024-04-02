using UnityEngine;

public class GetFood : MonoBehaviour
{
    [SerializeField] Transform foodSource1;
    [SerializeField] Transform foodSource2;
    [SerializeField] float standoff;
    [SerializeField] float speed;


    void Update()
    {
        Transform target = GetCloserFoodSource();
        if (Vector3.Distance(transform.position, target.position) > standoff)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

            if (transform.position.x - target.position.x > 0)
            {
                transform.rotation = new Quaternion(0, 180, 0, 0);
            }
            else
            {
                transform.rotation = new Quaternion(0, 0, 0, 0);
            }
        }
    }

    private Transform GetCloserFoodSource()
    {
        if (Vector3.Distance(transform.position, foodSource1.position) < Vector3.Distance(transform.position, foodSource2.position))
        {
            return foodSource1;
        }
        return foodSource2;
    }

}

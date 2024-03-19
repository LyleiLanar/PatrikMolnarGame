using UnityEngine;

public class SpaceShip : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Vector2 direction;
    [SerializeField] float acceleration = 0.2f;
    [SerializeField] float maxSpeed;
    [SerializeField] float manouvering = 0.2f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Controll();
        Move();
    }

    void Accelerate()
    {
        if (speed < maxSpeed)
            speed += acceleration;
    }

    void Deceleration()
    {
        if (speed >= 0)
            speed -= acceleration;
    }

    void Move()
    {
        transform.position += (Vector3)(direction * speed * Time.deltaTime);
    }

    void Controll()
    {
        if (Input.GetKey(KeyCode.W))
            Accelerate();

        if (Input.GetKey(KeyCode.S))
            Deceleration();

        float x = Input.GetAxis("Horizontal");

        transform.rotation = new Quaternion(x, 0, 0, 0);

    }

}

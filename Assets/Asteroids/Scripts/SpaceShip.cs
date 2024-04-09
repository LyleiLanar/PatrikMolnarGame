using UnityEngine;

public class SpaceShip : MonoBehaviour
{
    [SerializeField] float acceleration;
    [SerializeField] float maxSpeed;
    [SerializeField] float manouvering;
    [SerializeField] float drag = 1.1f;
    Vector3 velocity;

    private void Update()
    {
        float z = Input.GetAxisRaw("Horizontal");

        //Mozgás
        Vector3 step = velocity * Time.deltaTime;
        transform.position += step;

        //Forgatás
        transform.Rotate(0, 0, -z * Time.deltaTime * manouvering);
    }

    // Akkor használjuk, amikor gyorsulást vagy lassulást kell használni.
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Bumm!"); // Pillanatszerû input nem való fixedUpdate-be!
        }

        //Input
        float y = Input.GetAxisRaw("Vertical");

        //Gyorsítás
        velocity += transform.up * acceleration * y * Time.fixedDeltaTime;

        //Lassítás (drag => közegellenállás)
        Vector3 dragVector = -velocity * drag;
        velocity += dragVector * Time.fixedDeltaTime;

        //Max sebesség
        velocity = Vector3.ClampMagnitude(velocity, maxSpeed);
    }
}

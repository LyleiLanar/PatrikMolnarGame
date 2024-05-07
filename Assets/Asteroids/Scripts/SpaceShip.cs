using UnityEngine;

public class SpaceShip : MonoBehaviour
{
    [SerializeField] float acceleration;
    [SerializeField] float maxSpeed;
    [SerializeField] float manouvering;
    //[SerializeField] float drag = 1.1f;

    Rigidbody2D rb;

    //Vector2 velocity;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            Vector2 g = Physics2D.gravity;
            g.x = -g.x;
            Physics2D.gravity = g;
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            Vector2 g = Physics2D.gravity;
            g.y = -g.y;
            Physics2D.gravity = g;

            // Ezt nem lehet megtenni...
            // Physics2D.gravity.x = -g.x;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Physics2D.gravity = -Physics2D.gravity;
        }

        float z = Input.GetAxisRaw("Horizontal");

        // *** RigidBody nélkül ***
        // Mozgás
        // transform.position += step;

        // Forgatás
        // transform.Rotate(0, 0, -z * Time.deltaTime * manouvering);

        // *** RigidBody***

        // Forgatás
        rb.angularVelocity = 0;

        float turnStep = -z * Time.deltaTime * manouvering;
        transform.Rotate(0, 0, turnStep);

        //rb.rotation += turnStep;
    }

    // Akkor használjuk, amikor gyorsulást vagy lassulást kell használni.
    void FixedUpdate()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    Debug.Log("Bumm!"); // Pillanatszerû input nem való fixedUpdate-be!
        //}

        //Input
        float y = Input.GetAxisRaw("Vertical");


        //Gyorsítás
        rb.velocity += acceleration * Time.fixedDeltaTime * y * (Vector2)transform.up;

        //Lassítás (drag => közegellenállás)
        // Rigidbody miatt nem kell;
        //Vector2 dragVector = -velocity * drag;
        //velocity += dragVector * Time.fixedDeltaTime;

        //Max sebesség
        rb.velocity = Vector2.ClampMagnitude(rb.velocity, maxSpeed);
    }
}

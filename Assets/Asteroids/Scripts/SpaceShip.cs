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

        //Mozg�s
        Vector3 step = velocity * Time.deltaTime;
        transform.position += step;

        //Forgat�s
        transform.Rotate(0, 0, -z * Time.deltaTime * manouvering);
    }

    // Akkor haszn�ljuk, amikor gyorsul�st vagy lassul�st kell haszn�lni.
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Bumm!"); // Pillanatszer� input nem val� fixedUpdate-be!
        }

        //Input
        float y = Input.GetAxisRaw("Vertical");

        //Gyors�t�s
        velocity += transform.up * acceleration * y * Time.fixedDeltaTime;

        //Lass�t�s (drag => k�zegellen�ll�s)
        Vector3 dragVector = -velocity * drag;
        velocity += dragVector * Time.fixedDeltaTime;

        //Max sebess�g
        velocity = Vector3.ClampMagnitude(velocity, maxSpeed);
    }
}

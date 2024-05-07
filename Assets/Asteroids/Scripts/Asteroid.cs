using UnityEngine;

public class Asteroid : MonoBehaviour
{
    [SerializeField] float maxSpeed = 20;
    [SerializeField] float maxAngualarSpeed = 90f;

    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.angularVelocity = Random.Range(-maxAngualarSpeed, maxAngualarSpeed);
        //rb.velocity = new Vector2(Random.Range(-1, 1), Random.Range(-1, 1)).normalized * Random.Range(0, maxSpeed);
        rb.velocity = Random.insideUnitSphere * maxSpeed;
    }

    private void Update()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.ClampMagnitude(rb.velocity, maxSpeed);
        rb.angularVelocity = Mathf.Clamp(rb.angularVelocity, -maxAngualarSpeed, maxAngualarSpeed);
    }

    private void OnDestroy()
    {
        FindAnyObjectByType<AsteroidsSpawner>().RemoveAsteroid(this);
    }
}

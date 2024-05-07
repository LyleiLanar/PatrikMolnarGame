using UnityEngine;

public class Bolt : MonoBehaviour
{
    [SerializeField] float speed = 20f;
    private readonly float lifeSpan = 3;
    [SerializeField] int damage = 10;
    Rigidbody2D rb;
    //private float age = 0;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity *= speed;
        Destroy(gameObject, lifeSpan);
    }

    private void Update()
    {
        rb.velocity = speed * transform.right;
        //transform.position += speed * Time.deltaTime * transform.right;
        //age += Time.deltaTime;
        //if (age > 2)
        //    transform.localScale = Vector3.one * Mathf.Lerp(1, 0 , age - 2);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vulnerable vurnerable = collision.gameObject.GetComponent<Vulnerable>();

        if (vurnerable != null)
            vurnerable.Damage(damage);

        Destroy(gameObject);
    }
    //private void OnTriggerEnter2D(Collider2D other)
    //{
    //    Vulnerable vurnerable = other.GetComponent<Vulnerable>();

    //    if (vurnerable != null)
    //    {
    //        vurnerable.Damage(damage);
    //    }

    //    Destroy(gameObject);

    //}


}

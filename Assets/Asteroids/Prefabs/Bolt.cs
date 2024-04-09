using UnityEngine;

public class Bolt : MonoBehaviour
{
    [SerializeField] float speed = 20f;
    private readonly float lifeSpan = 3;
    [SerializeField] int damage = 10;
    //private float age = 0;

    private void Start()
    {
        Destroy(gameObject, lifeSpan);
    }
    private void Update()
    {
        transform.position += speed * Time.deltaTime * transform.right;
        //age += Time.deltaTime;
        //if (age > 2)
        //    transform.localScale = Vector3.one * Mathf.Lerp(1, 0 , age - 2);

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Vulnerable vurnerable = other.GetComponent<Vulnerable>();

        if (vurnerable != null)
        {
            vurnerable.CurrentHp -= damage;
            Debug.Log(vurnerable.CurrentHp);
        }
        Destroy(gameObject);
    }


}

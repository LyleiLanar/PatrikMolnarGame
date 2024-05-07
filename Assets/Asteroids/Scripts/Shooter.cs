using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject boltPrototype;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newBolt = Instantiate(boltPrototype);
            Rigidbody2D boltRb = newBolt.GetComponent<Rigidbody2D>();

            newBolt.transform.position = transform.position;
            newBolt.transform.rotation = transform.rotation;
            boltRb.velocity = transform.up;
        }
    }
}

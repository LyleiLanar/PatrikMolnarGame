using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject boltPrototype;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newProjectile = Instantiate(boltPrototype);
            newProjectile.transform.position = transform.position;
            newProjectile.transform.rotation = transform.rotation;
        }
    }
}

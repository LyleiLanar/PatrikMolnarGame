using UnityEngine;

public class MyFirstScript : MonoBehaviour
{

    [SerializeField] float speed = 1.0f;
    void Start()
    {
        Debug.Log("Hello Unity!!");
        Debug.Log("I'm " + name);
    }
    void Update()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;
        transform.rotation *= Quaternion.Euler(Vector3.up * 100 * speed * Time.deltaTime);
    }
}

using UnityEngine;

public class TranslateToTarget : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float maxTranslate;
    private Vector2 originalPosition;


    private void Start()
    {
        originalPosition = transform.position;
    }

    void Update()
    {
        Vector2 direction = (Vector2)target.position - originalPosition;

        if (direction.magnitude < maxTranslate)
            transform.position = target.position;
        else
            transform.position = originalPosition + Vector2.ClampMagnitude(direction, maxTranslate);

    }
}

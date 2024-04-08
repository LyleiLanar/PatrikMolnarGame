using UnityEngine;

public class ScreenTeleporter : MonoBehaviour
{
    new Camera camera;
    //SpriteRenderer spriteRenderer;
    new PolygonCollider2D collider;

    private void Start()
    {
        camera = Camera.main;
        //spriteRenderer = GetComponent<SpriteRenderer>();
        collider = GetComponent<PolygonCollider2D>();
    }

    private void Update()
    {
        Vector2 cameraCenter = camera.transform.position;
        Vector2 cameraSize = new(camera.orthographicSize * camera.aspect, camera.orthographicSize);
        Rect cameraRect = new(cameraCenter - cameraSize, cameraSize * 2);
        Bounds bounds = collider.bounds;

    }

    private void OnDrawGizmos()
    {
        if (collider == null) return;

        //Bounds bounds = spriteRenderer.bounds;
        Bounds bounds = collider.bounds; // Visszaadja a sprite befogaló téglatestjét.

        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(bounds.center, bounds.size);
    }
}

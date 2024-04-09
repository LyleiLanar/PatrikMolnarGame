using UnityEngine;

public class ScreenTeleporter : MonoBehaviour
{
    new Camera camera;
    //SpriteRenderer spriteRenderer;
    new Collider2D collider;

    private void Start()
    {
        camera = Camera.main;
        //spriteRenderer = GetComponent<SpriteRenderer>();
        collider = GetComponent<Collider2D>();
    }

    private void Update()
    {
        Vector2 cameraCenter = camera.transform.position;
        Vector2 cameraSize = new(camera.orthographicSize * camera.aspect, camera.orthographicSize);
        Rect cameraRect = new(cameraCenter - cameraSize, cameraSize * 2);
        Bounds objectBounds = collider.bounds;

        float yJump = cameraSize.y * 2 + objectBounds.size.y;
        float xJump = cameraSize.x * 2 + objectBounds.size.x;

        if (cameraRect.yMax < objectBounds.min.y)
        {
            transform.position += Vector3.down * yJump;
            //A boundsokat nem minden updateben frissíti. Ezért ki kell erõszakolni egy ilyen eseteben ezt a szinkront.
            Physics2D.SyncTransforms();
        }

        if (cameraRect.yMin > objectBounds.max.y)
        {
            transform.position += Vector3.up * yJump;
            Physics2D.SyncTransforms();
        }

        if (cameraRect.xMax < objectBounds.min.x)
        {
            transform.position += Vector3.left * xJump;
            Physics2D.SyncTransforms();
        }

        if (cameraRect.xMin > objectBounds.max.x)
        {
            transform.position += Vector3.right * xJump;
            Physics2D.SyncTransforms();
        }
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

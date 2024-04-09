using UnityEngine;

public class PositionDrawer : MonoBehaviour
{
    [SerializeField] float axisSize;
    [SerializeField] float ballSize;

    private void OnDrawGizmos()
    {
        DrawAxis(Color.red, transform.right);
        DrawAxis(Color.green, transform.up);
        DrawAxis(Color.blue, transform.forward);
    }

    private void DrawAxis(Color color, Vector3 direction)
    {
        Vector3 position = transform.position;
        Gizmos.color = color;
        Vector3 sizedDirection = direction * axisSize;
        Gizmos.DrawLine(position - sizedDirection, position + sizedDirection);
        Gizmos.DrawSphere((position + direction * axisSize), ballSize);

    }
}

using UnityEngine;

public class PositionDrawer : MonoBehaviour
{
    [SerializeField] float axisSize;
    [SerializeField] float ballSize;

    enum Axis
    {
        x, y, z
    }

    private void OnDrawGizmos()
    {
        DrawAxis(Axis.x);
        DrawAxis(Axis.y);
        DrawAxis(Axis.z);
    }

    private void DrawAxis(Axis axis)
    {
        Vector3 direction;
        Color color;

        switch (axis)
        {
            case Axis.x:
                direction = transform.right;
                color = Color.red;
                break;

            case Axis.y:
                direction = transform.up;
                color = Color.green;
                break;

            case Axis.z:
                direction = transform.forward;
                color = Color.blue;
                break;

            default:
                direction = Vector3.zero;
                color = Color.white;
                break;
        }

        Gizmos.color = color;

        Gizmos.DrawLine(transform.position, (transform.position + direction * axisSize));
        Gizmos.DrawLine(transform.position, (transform.position - direction * axisSize));
        Gizmos.DrawSphere((transform.position + direction * axisSize), ballSize);

    }
}

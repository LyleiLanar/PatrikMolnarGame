using UnityEngine;

public class Brakeable : MonoBehaviour
{

    [SerializeField] GameObject children;
    [SerializeField] int amount;

    public GameObject Children { get => children; }
    public int Amount { get => amount; }
}

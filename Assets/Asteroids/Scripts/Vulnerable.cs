using UnityEngine;

public class Vulnerable : MonoBehaviour
{
    [SerializeField] int maxHp = 100;
    private int currentHp;

    public int CurrentHp { get => currentHp; set => currentHp = value; }

    private void Start()
    {
        CurrentHp = maxHp;
    }

    void Update()
    {
        if (currentHp <= 0)
            Destroy(gameObject);
    }
}

using UnityEngine;

public struct Item
{
    public string name;
    public int price;

    public Item(string name, int price)
    {
        this.name = name;
        this.price = price;
    }
}

public class Vampire : MonoBehaviour
{
    [SerializeField] int hp;
    [SerializeField] int coins;
    [SerializeField] bool moringstar;
    [SerializeField] bool dagger;
    [SerializeField] bool vampireTooth;

    private Item MORNINGSTAR = new("Morningstar of The Clubs", 10);
    private Item DAGGER = new("Tricky Dagger", 4);
    private Item TOOTH = new("Vampire Tooth", 13);

    private readonly int LIFE_VALUE = 5;

    private void OnValidate()
    {
        moringstar = IsItAffordable(MORNINGSTAR);
        dagger = IsItAffordable(DAGGER);
        vampireTooth = IsItAffordable(TOOTH);

    }

    private bool IsItAffordable(Item item) => (IsAffordableFromCoin(item.price) || IsAffordableFromBlood(item.price));

    private bool IsAffordableFromCoin(int price) => price <= coins;

    private bool IsAffordableFromBlood(int price) => price * LIFE_VALUE < hp;
}

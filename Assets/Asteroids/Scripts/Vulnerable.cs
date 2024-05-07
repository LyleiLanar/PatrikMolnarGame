using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Vulnerable : MonoBehaviour
{
    [SerializeField] int maxHp = 100;
    [SerializeField] int collisonBaseDamage = 1;
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] List<Sprite> sprites;

    [SerializeField] TMP_Text healthText;

    private int currentHp;
    private bool isSetup = false;

    public int CurrentHp { get => currentHp; }

    private void OnValidate()
    {
        if (spriteRenderer == null)
            spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        currentHp = maxHp;
        isSetup = true;
        UpdateHealthText();
    }

    public void Damage(int damage)
    {
        if (damage < 0)
            return;

        if (damage > currentHp)
            damage = currentHp;

        currentHp -= damage;
        UpdateHealthText();

        if (currentHp > 0)
        {
            UpdateSprite();
        }
        else
        {
            Brakeable br = GetComponent<Brakeable>();
            if (br != null)
            {
                for (int i = 0; i < br.Amount; i++)
                {
                    GameObject go = Instantiate(br.Children);

                    Vector2 newPosition = Random.insideUnitCircle.normalized * 1;
                    go.transform.position = (Vector2)transform.position + newPosition;
                }
            }
            Destroy(gameObject);
        }
    }

    private void UpdateHealthText()
    {
        if (healthText != null)
            healthText.text = $"HEALTH: {currentHp}";
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        int damage = (int)Mathf.Clamp(collision.relativeVelocity.magnitude, 1, 20);
        if (isSetup)
            Damage(damage);
    }

    private void UpdateSprite()
    {
        if (spriteRenderer == null) return;

        if (sprites.Count == 0 || sprites == null) return;

        float healthRate = (float)currentHp / maxHp;
        healthRate = 1 - healthRate;
        int index = Mathf.RoundToInt((sprites.Count - 1) * healthRate);
        spriteRenderer.sprite = sprites[index];

    }
}

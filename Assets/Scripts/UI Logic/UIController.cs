using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] private Image healthBar;
    [SerializeField] private Image manaBar;
    [SerializeField] private Sprite[] healthSprites;
    [SerializeField] private Sprite[] manaSprites;

    private int currentHealth;
    private int currentMana;

    void Start()
    {
        currentHealth = 100;
        currentMana = 100;
        UpdateHealthBar();
        UpdateManaBar();    
    }

    public void UpdateUI(int health, int mana)
    {
        UpdateManaUI(health);
        UpdateHealthUI(mana);
    }

    private void UpdateHealthUI(int health)
    {
        currentHealth = health;
        UpdateHealthBar();
    }

    private void UpdateManaUI(int mana)
    {
        currentMana = mana;
        UpdateManaBar();
    }

    private void UpdateHealthBar()
    {
        int index = Mathf.Clamp(currentHealth / 20, 0, 4);
        healthBar.sprite = healthSprites[index];
    }

    private void UpdateManaBar()
    {
        int index = Mathf.Clamp(currentMana / 20, 0, 4);
        manaBar.sprite = manaSprites[index];
    }
}

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

    private AllHealth AllHealth;

    void Start()
    {
        UpdateHealthBar(100);
        UpdateManaBar(100);    
    }

    public void UpdateUI(float health, float mana)
    {
        UpdateManaBar(mana);
        UpdateHealthBar(health);
    }

    private void UpdateHealthBar(float health)
    {
        int index = Mathf.Clamp(Mathf.RoundToInt(health) / 20, 0, 4);
        healthBar.sprite = healthSprites[index];
    }

    private void UpdateManaBar(float mana)
    {
        int index = Mathf.Clamp(Mathf.RoundToInt(mana) / 20, 0, 4);
        manaBar.sprite = manaSprites[index];
    }
}

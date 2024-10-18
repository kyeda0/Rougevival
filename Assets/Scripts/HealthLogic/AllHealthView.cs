using UnityEngine;
using UnityEngine.UI;

public class AllHealthView : MonoBehaviour
{
    [SerializeField] private Image healthBar;
    [SerializeField] private Image manaBar;
    [SerializeField] private Sprite[] healthSprites;
    [SerializeField] private Sprite[] manaSprites;

    private AllHealth _allHealth;

    void Start()
    {
        UpdateHealthBar(_allHealth._currentHealth);
        UpdateManaBar(100f);    
    }

    public void UpdateUI(float health, float mana)
    {
        UpdateManaBar(mana);
        UpdateHealthBar(health);
    }

    public  void UpdateHealthBar(float health)
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

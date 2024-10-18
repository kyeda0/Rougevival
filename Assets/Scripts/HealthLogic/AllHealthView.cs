using UnityEngine;
using UnityEngine.UI;

public class AllHealthView : MonoBehaviour
{
   [SerializeField] private Image _healthBar;

   private UIController UI;


    private void Start()
    {
        UI = GameObject.FindWithTag("UI").GetComponent<UIController>();
    }
   public void UpdateHealthBar(float _currentHealth, float _maxHealth)
   {
        if(_healthBar!=null)
        {
            _healthBar.fillAmount = _currentHealth/_maxHealth;
        }
   } 
}

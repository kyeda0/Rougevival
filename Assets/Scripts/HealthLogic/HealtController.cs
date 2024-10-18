using System;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    private AllHealth _allHealth;
    private UIController _UI;
    private AllHealthView _allHealthView;
    private  void Awake()
    {
        _allHealthView = GetComponent<AllHealthView>();
        // _UI = GameObject.FindWithTag("UI").GetComponent<UIController>();
    }

    public void Initialize(float maxHealth){
        _allHealth = new AllHealth (maxHealth);
        _allHealthView.UpdateHealthBar(_allHealth._currentHealth,_allHealth.maxHealth);

    }

    public void TakeDamage(float _damage){
        _allHealth.TakeDamage(_damage);

        _allHealthView.UpdateHealthBar(_allHealth._currentHealth,_allHealth.maxHealth);
        
        // _UI.UpdateUI(_allHealth._currentHealth, 100); 

        if(_allHealth.IsDead()){
            Kill();
        }
    }

    public void Heal(float _amount)
    {
        _allHealth.Heal(_amount);
        _allHealthView.UpdateHealthBar(_allHealth._currentHealth, _allHealth.maxHealth);
    }

    private void Kill(){
        Destroy(gameObject);
    }
 
}

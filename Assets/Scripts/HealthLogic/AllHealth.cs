using UnityEngine;

public class AllHealth 
{
    public  float maxHealth {get; private set;}
    public float _currentHealth {get;  private set;}


    public  AllHealth (float _maxHealth){
        maxHealth = _maxHealth;
        _currentHealth = _maxHealth;

    }

    public void TakeDamage(float _damage){
        _currentHealth -= _damage;
    }

    public void Heal(float _amount){
        _currentHealth += _amount;
    }

    public bool IsDead(){
        return _currentHealth <= 0;
    }

}

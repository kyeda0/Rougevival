using UnityEngine;

public class Character : MonoBehaviour
{
    protected HealthController _healthController;
    protected MovementController _movementController;

    protected void InitializeCharacter(float _maxHealth = 0, float _speed = 0){
        _movementController = GetComponent<MovementController>();
        _healthController = GetComponent<HealthController>();

        if( _healthController == null){
            return;
        }
        
        _healthController.Initialize(_maxHealth);

        if( _speed > 0)
        {
            if( _movementController == null){
                return;
            }
            _movementController.Initialize(_speed);
        }
    }


    public void TakeDamage(float _damage)
    {
        _healthController.TakeDamage(_damage);
    }

    public void Heal(float _amount){
        _healthController.Heal(_amount);
    }

    public void Movement(float _speed){
        _movementController.Movement(_speed);
    }
}


    

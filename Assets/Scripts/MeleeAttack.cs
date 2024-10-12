using UnityEngine;

public class PlayerMeleeAttack : MonoBehaviour
{
    [Header("Attack Settings")]
    [SerializeField] private Transform attackPoint;              
    [SerializeField] private LayerMask enemyLayers;   
    private Player _player;

    void Start(){_player = transform.GetComponent<Player>();}
    private void Update(){
        if(_player._weaponData== null){return;}
        if(Input.GetMouseButton(0) && _player._weaponData._currentTimeAttack <= 0){
            Attack(_player._weaponData);
            _player._weaponData._currentTimeAttack = _player._weaponData._startTimeAttack;
        }
        else{ _player._weaponData._currentTimeAttack -= Time.deltaTime;}
    }

    public  void Attack(WeaponData _currentWeapon)
    {
        if( _currentWeapon != null)
        {
            Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, _currentWeapon._attackRange, enemyLayers);

            foreach (Collider2D enemy in hitEnemies)
            {
                enemy.GetComponent<Enemy>().TakeDamage(_currentWeapon._damage);
                Debug.Log("Ударил " + enemy.name + " с урона: " + _currentWeapon._damage);
            }
        }
        else if(_currentWeapon==null){return;}
    }


}

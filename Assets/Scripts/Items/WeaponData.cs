using UnityEngine;

[CreateAssetMenu(fileName ="New Weapon" , menuName = "Weapon/Weapon")]
public class WeaponData : ItemsData
{
   public float _damage;
   public float _speed;
   public float _attackRange;
   public GameObject _prefabWeapons;
   public float _startTimeAttack;

   public float _currentTimeAttack;
}

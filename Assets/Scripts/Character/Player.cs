using UnityEngine;

public class Player : Character
{
    [SerializeField] private float _maxHealth;
    [SerializeField] private float _speed;
    [SerializeField] private  Transform _weaponSlot;
    [SerializeField] private  GameObject _currentWeapon ;
    public  WeaponData _weaponData;    
    void Start()
    {
        InitializeCharacter(_maxHealth, _speed);
    }

    void Update()
    {
        Movement(_speed);
    }

    
    public void EquipWeapon(WeaponData _weaponItem)
    {
        if(_weaponItem == null){ Debug.Log ("null weaponItem");return;}
        if(_currentWeapon == null){ Debug.Log ("null _currentWeapon");return;}
        if(_currentWeapon != null){Destroy(_currentWeapon.gameObject);_currentWeapon = Instantiate(_weaponItem._prefabWeapons,_weaponSlot.position,_weaponSlot.rotation,_weaponSlot);}
        _weaponData = _weaponItem;
    }
}

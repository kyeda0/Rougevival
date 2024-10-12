using UnityEngine;

public class Enemy : Character
{
    [SerializeField] private float _maxHealth;
    void Start()
    {
        InitializeCharacter(_maxHealth);
    }

    void Update()
    {
         if(Input.GetKeyDown(KeyCode.Space)){
        }
    }
}

using UnityEngine;
using UnityEngine.UI;

public class HealthBarFollow : MonoBehaviour
{
    [SerializeField] private Vector3 _offset;
    [SerializeField] private Image _healthBar;
    private Enemy _enemy;
    private Camera _mainCamera;
    private void Start()
    {
        _mainCamera = Camera.main;
        _enemy = GameObject.FindWithTag("Enemy").GetComponent<Enemy>();
    }

    void Update()
    {
        
    }


    private void FollowHealth(){
        if (_enemy != null)
        {
            Vector3 _screenPos = _mainCamera.WorldToScreenPoint(_enemy.transform.position + _offset);
            transform.position = _screenPos;
        }
        
    }
}

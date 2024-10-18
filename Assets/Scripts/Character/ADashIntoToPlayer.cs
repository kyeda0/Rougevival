using System.Collections;
using UnityEngine;

public class ADashIntoToPlayer : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _rangeDash;
    [SerializeField] private float _cooldowDash;
    [SerializeField] private float _dashDuration;
    [SerializeField] private float _damage;
    private Player _player;
    private bool _canDash = true;



    private void Start(){
        _player = GameObject.FindWithTag("Player").GetComponent<Player>();
    }
    private void Update()
    {
        if(_canDash){
            float _distanteToPlayer = Vector2.Distance(_player.transform.position,transform.position);
            if(_distanteToPlayer <= _rangeDash){
                StartCoroutine(DashToPlayer());
            }
        }
    }

    private IEnumerator DashToPlayer(){
        _canDash = false;

        Vector2 _dashDirection = (_player.transform.position - transform.position).normalized;

        float _dashTime = 0;
        while(_dashTime <= _dashDuration){
            transform.position += (Vector3)_dashDirection * _speed * Time.deltaTime;

            _dashTime+=Time.deltaTime;

            yield return null;
        }

        yield return new WaitForSeconds(_cooldowDash);
        _canDash = true;
    }

    private void OnDrawGizmos(){
        if(transform.position == null){return;}
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position,_rangeDash);
    }
    private void OnTriggerEnter2D(Collider2D _collider2d){
        if(_collider2d.CompareTag("Player")){
            _player.TakeDamage(_damage);
        }
    }
}

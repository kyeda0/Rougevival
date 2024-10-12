using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private Vector3 _offset;
    [SerializeField] private float _smoothSpeed;
   
    private void LateUpdate(){
        CameraFollowtoPlayer();
    }

    private void CameraFollowtoPlayer(){

        if(_playerTransform == null){return;}
        Vector3 _targetPos = _playerTransform.position + _offset;

        Vector3 _smoothVector = Vector3.Lerp(transform.position, _targetPos, _smoothSpeed);

        transform.position = _smoothVector;
    }
}

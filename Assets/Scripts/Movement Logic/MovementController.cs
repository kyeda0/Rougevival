using UnityEngine;

public class MovementController : MonoBehaviour
{
   private MovementLogic _movementLogic;
   private MovementView _movementView;
   private void Awake(){
        _movementView = GetComponent<MovementView>();
   }

   public void Initialize(float _speed){
        _movementLogic = new MovementLogic(_speed);
        _movementView.UpdatePosition(_movementLogic._position);
   }


   public void Movement(float _speed){
        Vector2 _inputDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        if(_inputDirection != Vector2.zero)
        {
            _movementLogic.Movement(_inputDirection * _speed);
            _movementView.UpdatePosition(_movementLogic._position);
        }
   }
}

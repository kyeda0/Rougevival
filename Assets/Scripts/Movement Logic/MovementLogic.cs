using UnityEngine;

public class MovementLogic  
{
   public Vector2 _position { get; private set; }
   public float speed { get; private set; }


   public MovementLogic(float _speed){
    speed = _speed;
   }

   public void Movement( Vector2 _direction)
   {
    _position += _direction * speed * Time.deltaTime;
   }
}

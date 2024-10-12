using UnityEngine;

public class MovementView : MonoBehaviour
{
  public void UpdatePosition(Vector2 _changePosition){
    transform.position = new Vector3 (_changePosition.x,_changePosition.y,transform.position.z);
  }
}

using UnityEngine;

public class AnimationPlayer : MonoBehaviour
{
   [SerializeField] private KeyCode _leftWalk;
   [SerializeField] private KeyCode _rightWalk;
   [SerializeField] private KeyCode _upWalk;
   [SerializeField] private KeyCode _downWalk;

    private Animator _animator;

    private void Start(){
        _animator = transform.GetComponent<Animator>();
    }

    private void Update(){
        if(Input.GetKeyDown(_upWalk)){_animator.SetTrigger("upWalk");}
        
        else if(Input.GetKeyUp(_upWalk)){_animator.SetTrigger("idleUp");}
         
         if(Input.GetKeyDown(_downWalk)){_animator.SetTrigger("downWalk");}
        
        else if(Input.GetKeyUp(_downWalk)){_animator.SetTrigger("idle");}
         
         if(Input.GetKeyDown(_rightWalk)){_animator.SetTrigger("rightWalk");}
        
        else if(Input.GetKeyUp(_rightWalk)){_animator.SetTrigger("IdleRight");}
         
         if(Input.GetKeyDown(_leftWalk)){_animator.SetTrigger("leftWalk");}
        
        else if(Input.GetKeyUp(_leftWalk)){_animator.SetTrigger("idleLeft");}
    }
}

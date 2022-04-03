
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class PlayerController : MonoBehaviour
{
   [SerializeField] [Range(1f, 100f)]float Speed,Rotation;

    private Rigidbody rb;
    //private PlayerAnimation animation;
    private float MoveX, MoveY;

    // Start is called before the first frame update
    void Awake(){
        rb = GetComponent<Rigidbody>();
        //animation=GetComponent<PlayerAnimation>();
    }

    private void OnMove(){

        MoveX=CrossPlatformInputManager.GetAxisRaw("Horizontal");
        MoveY=CrossPlatformInputManager.GetAxisRaw("Vertical");
        Vector3 movement=new Vector3(MoveY,0,0).normalized*Speed*Time.deltaTime;
        rb.velocity=transform.position + movement; 
        transform.Rotate(Vector3.down*Rotation*MoveX);
        //animation.Animation(MoveY, MoveX);

    }

    private void Update(){
        OnMove();
    }

}

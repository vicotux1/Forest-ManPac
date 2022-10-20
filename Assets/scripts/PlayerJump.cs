using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [Header("Jump")]
    [SerializeField]string ButtonJump="Jump";
    [SerializeField]float Jump_Speed=600.0f;
    [SerializeField]bool IsGrounded=false;
    public Transform grounded_Check;
    public float Radius=2.0f;
    public LayerMask Layer;

    private new Rigidbody rigidbody;
    Animator anim;
    bool b_Jump;
    private void Awake() {
        rigidbody=GetComponent<Rigidbody>();
        anim=gameObject.GetComponent<Animator>();        
        if(grounded_Check==null){
            grounded_Check=GameObject.Find("Ground_Check").transform;
        }
    } 

    #region Salto
    public void _Jump(bool is_jump){
        if(is_jump ){
             rigidbody.AddForce(new Vector2(0,Jump_Speed));
            }
        }
    #endregion  

    // Update is called once per frame
    void Update(){
        IsGrounded=Physics2D.OverlapCircle(grounded_Check.position, Radius,Layer);
        
        b_Jump=Input.GetButton(ButtonJump);
        _Jump(b_Jump);
    }
}

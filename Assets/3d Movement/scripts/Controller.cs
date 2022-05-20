using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [Header("Player Movement")]
    [SerializeField][Range(0.1f, 10.0f)]float Speed=0.1f;
    [SerializeField] Transform MeshPlayer;
    [SerializeField] string Horizontal, Vertical,Fire;
    private  CharacterController _controller;
    float Axis_Horizontal, Axis_Vertical;
    Animator _anim;

    private void Start(){
        _controller=GetComponent<CharacterController>();
        _anim=gameObject.GetComponent<Animator>();
        Cursor.visible = true; 
       }
     
    void Update(){
        Axis_Horizontal=Input.GetAxis(Horizontal);
        Axis_Vertical=Input.GetAxis(Vertical);
        Movement(Axis_Horizontal, Axis_Vertical);
        Attack();        
    } 
        void Attack(){
            if(Input.GetButtonDown(Fire)){
                _anim.SetBool("Hit", true);
            }else{
                 _anim.SetBool("Hit", false);
            }
        }

        void Movement(float Horizontal, float Vertical){
            //Movement
            Vector3 move=new Vector3(Vertical,0,Horizontal);
            //rotate transform
            Vector3 Rotation=new Vector3 (move.x,0, move.z);
            _controller.Move(move * Time.deltaTime * Speed);
             _anim.SetFloat("Speed", Axis_Vertical); 
            if (Horizontal!=0 || Vertical!=0){
                
               _anim.SetBool("Rotate", true); 
                //rotate transform
            MeshPlayer.rotation= Quaternion.LookRotation(Rotation);
            }else{
               _anim.SetBool("Rotate", false);  
            }
    } 
    
}

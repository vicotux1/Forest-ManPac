using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour{
    #region Variables
    [SerializeField] Transform MeshPlayer;
    [SerializeField][Range(0.001f, 20.0f)]float Speed=0.1f, Gravity,SpeedRun;
    [SerializeField] string Horizontal, Vertical, Run;
    [SerializeField]  Vector3 Posicion_inicial;
    float Velocidad;
    
    private  CharacterController _controller;
    float Axis_Horizontal, Axis_Vertical;
    Animator _anim;
    #endregion
    #region Unity_Methods
    private void Awake(){
        _controller=GetComponent<CharacterController>();
        _anim=gameObject.GetComponent<Animator>();
        Cursor.visible = true; 
        transform.position=Posicion_inicial;
        Velocidad=Speed;
       }
     
    void Update(){
        Movement();      
    } 
    #endregion

    #region Movement
        void Movement(){   
        Axis_Horizontal=Input.GetAxis(Horizontal);
        Axis_Vertical=Input.GetAxis(Vertical);
        Vector3 Move=new Vector3(Axis_Vertical,-Gravity,Axis_Horizontal);
            
            if(Input.GetButton(Run)){               
                _anim.SetBool("Runner", true); 
                _anim.SetFloat("IsRunV", Axis_Vertical);
                _anim.SetFloat("IsRunH", Axis_Horizontal); 
                _controller.Move(Move * Time.deltaTime * SpeedRun); 
            }
            else{ 
                _anim.SetBool("Runner",false); 
                _anim.SetFloat("SpeedV", Axis_Vertical); 
                _anim.SetFloat("SpeedH", Axis_Horizontal);
                _controller.Move(Move * Time.deltaTime * Speed);  
        }
        Rotate(Move);      
    } 
    void Rotate(Vector3 move){
        //rotate transform
        Vector3 Rotation=new Vector3 (move.x,0, move.z);
         if (Axis_Horizontal!=0 || Axis_Vertical!=0){
          MeshPlayer.rotation= Quaternion.LookRotation(Rotation);
          
        }
    }
    #endregion
}

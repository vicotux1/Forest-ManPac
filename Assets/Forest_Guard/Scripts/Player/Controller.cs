using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour{
    
    [SerializeField] Transform MeshPlayer;
    [SerializeField][Range(0.001f, 20.0f)]float Speed=0.1f, Gravity,SpeedRun;
    [SerializeField] string Horizontal, Vertical, Run;
    [SerializeField]  Vector3 Posicion_inicial;
    float Velocidad;
    
    private  CharacterController _controller;
    float Axis_Horizontal, Axis_Vertical;
    Animator _anim;

    private void Start(){
        _controller=GetComponent<CharacterController>();
        _anim=gameObject.GetComponent<Animator>();
        Cursor.visible = true; 
        transform.position=Posicion_inicial;
        Velocidad=Speed;
       }
     
    void Update(){
        
        Axis_Horizontal=Input.GetAxis(Horizontal);
        Axis_Vertical=Input.GetAxis(Vertical);
        Movement(Axis_Horizontal, Axis_Vertical); 
        //_Run();      
    } 
       void _Run(){
       if(Input.GetButton(Run)){
                Speed=SpeedRun;
                Debug.Log(Speed);
            }else{ Speed=Velocidad;
            Debug.Log(Speed);
        }
    }    

        void Movement(float Horizontal, float Vertical){
                        
            //Movement
            Vector3 move=new Vector3(Vertical,-Gravity,Horizontal);
            //rotate transform
            Vector3 Rotation=new Vector3 (move.x,0, move.z);

            if(Input.GetButton(Run)){
                _controller.Move(move * Time.deltaTime * SpeedRun);
             _anim.SetBool("Runner", true); 
                }else{ _controller.Move(move * Time.deltaTime * Speed);
                _anim.SetBool("Runner",false); 
             _anim.SetFloat("Speed", Axis_Vertical); 
        }

            
            
            if (Horizontal!=0 || Vertical!=0){
                
               _anim.SetBool("Rotate", true); 
                //rotate transform
            MeshPlayer.rotation= Quaternion.LookRotation(Rotation);
            }else{
               _anim.SetBool("Rotate", false);  
            }
    } 
    
}

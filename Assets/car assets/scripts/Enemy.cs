using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] string TagPlayer="Jugador";
    [SerializeField][Range(10,100)] int Value=10;
    [SerializeField]bool IsCoin;
    [SerializeField]Animator anim;
    public EnemyGrunt_ia  ScriptIA;
    [SerializeField]bool IsDead;
    [SerializeField]AudioSource audioSource;

    [SerializeField]GameManager GameManager;
    void Update(){
      if(GameManager.Ejemplo==true){
       IsCoin=true;
      }else{
         IsCoin=false;
      }
    }
    void Awake(){
      if(GameManager==null){
        GameManager=FindObjectOfType<GameManager>();
        Debug.Log(GameManager.Ejemplo);
        IsDead=false;
        }
      }
    
    void OnTriggerEnter(Collider other){
		if (other.tag == TagPlayer){
      GameManager.Hearts-=Value;
      GameManager.Points-=(Value/2);
      if (IsCoin==true&& IsDead==false){
        IsCoin=false;
        IsDead=true;
        audioSource.Play();
        GameManager.Points+=Value;
         anim.SetBool("Dead",true);
         ScriptIA.enabled=false;
         transform.position=new Vector3(transform.position.x,-1.5f,transform.position.z);
         Value=0;
        Destroy (audioSource);
        
        }
      }
  } 
}

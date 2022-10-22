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
    [SerializeField] Collider ColiderEnemy;
    [SerializeField]AudioSource audioSource;
    [SerializeField] AudioClip _Coin;
    [SerializeField] AudioClip _Dead;

    [SerializeField]GameManager GameManager;
    void Update(){
      if(GameManager.IsCoin==true){
       IsCoin=true;
      }else{
         IsCoin=false;
      }
    }
    void Awake(){
      if(GameManager==null){
        GameManager=FindObjectOfType<GameManager>();
        //Debug.Log(GameManager.Ejemplo);
        IsDead=false;
        }
      }
    
    void OnTriggerEnter(Collider other){
		if (other.tag == TagPlayer){
      audioSource.clip=_Coin;
      GameManager.Hearts-=Value;
      GameManager.Points-=(Value/2);
      audioSource.Play();
      if (IsCoin==true&& IsDead==false){
        audioSource.clip=_Dead;
        IsCoin=false;
        IsDead=true;
        audioSource.Play();
        GameManager.Points+=Value;
         anim.SetBool("Dead",true);
         ColiderEnemy.enabled=false;
         ScriptIA.enabled=false;
         transform.position=new Vector3(transform.position.x,-1.5f,transform.position.z);
         Value=0;
        }
      }
  } 
}

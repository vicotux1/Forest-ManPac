using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] string TagPlayer="Jugador";
    [SerializeField] Collider capsuleCollider;
    public Color Verde, Rojo;
    public Renderer renderer;
    [SerializeField][Range(1,2)] int Serialid=1;
    [SerializeField] float waitTime;
    GameManager GameManager;
    [SerializeField]int Points=10;

    void OnTriggerEnter(Collider other){
		if (other.tag == TagPlayer){
      if (Serialid==2){
        GameManager.Coins--;
        GameManager.Ejemplo=true;
        Debug.Log(GameManager.Ejemplo);
        capsuleCollider.isTrigger=false;
        renderer.material.color=Rojo;
        StartCoroutine(VidaEnemy());
        }else{        
        GameManager.Points+=Points;
        GameManager.Coins--;
        Debug.Log(GameManager.Ejemplo);
        Destroy (this.gameObject);
        }
    
      } 
    }  

      void Awake(){
           GameManager.Coins++;
           if(GameManager==null){
        GameManager=FindObjectOfType<GameManager>();

        }   
      } 
      IEnumerator VidaEnemy(){
      yield return new WaitForSeconds(waitTime);
      GameManager.Ejemplo=false;
      Debug.Log("tiempo acabado");
      Destroy (this.gameObject);
      }

}

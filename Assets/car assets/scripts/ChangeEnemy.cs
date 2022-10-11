using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeEnemy : MonoBehaviour
{
    [SerializeField] string TagPlayer="Jugador";
    [SerializeField] Collider capsuleCollider;
    public Color Verde, Rojo;
    public Renderer renderer;
    [SerializeField] float waitTime;
    GameManager GameManager;

    void OnTriggerEnter(Collider other){
		if (other.tag == TagPlayer){
        GameManager.IsCoin=true;
        //Debug.Log(GameManager.Ejemplo);
        capsuleCollider.isTrigger=false;
        renderer.material.color=Rojo;
        StartCoroutine(VidaEnemy());
        }
    }  

      void Awake(){
           if(GameManager==null){
        GameManager=FindObjectOfType<GameManager>();

        }   
      } 
      IEnumerator VidaEnemy(){
      yield return new WaitForSeconds(waitTime);
      GameManager.IsCoin=false;
      Debug.Log("tiempo acabado");
      Destroy (this.gameObject);
      }

}

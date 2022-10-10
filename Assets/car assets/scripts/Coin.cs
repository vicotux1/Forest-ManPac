using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour{
    [SerializeField] string TagPlayer="Jugador";
    [SerializeField]int Points=10;
    [SerializeField]AudioSource audioSource;
    GameManager GameManager;

    void OnTriggerEnter(Collider other){
		if (other.tag == TagPlayer){ 
        audioSource.Play();      
        GameManager.Points+=Points;
        GameManager.Coins--;
        Destroy (this.gameObject);
        
        }
    }  

      void Awake(){
           GameManager.Coins++;
           if(GameManager==null){
        GameManager=FindObjectOfType<GameManager>();

        }   
      } 

}

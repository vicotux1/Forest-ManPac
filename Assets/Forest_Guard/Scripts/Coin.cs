using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour{
    [SerializeField] string TagPlayer="Jugador";
    [SerializeField] SphereCollider ColiderCoin;
    [SerializeField] GameObject thisCoin;
    [SerializeField]int Points=10;
    [SerializeField]AudioSource audioSource;
    [SerializeField] AudioClip _Coin;

    GameManager GameManager;

    void OnTriggerEnter(Collider other){
		if (other.tag == TagPlayer){ 
       audioSource.clip=_Coin;
        audioSource.Play();      
        GameManager.Points+=Points;
        GameManager.Coins--;
       thisCoin.SetActive(false);
       ColiderCoin.enabled=false;
        
        }
    }  

      void Awake(){
           GameManager.Coins++;
           if(GameManager==null){
        GameManager=FindObjectOfType<GameManager>();

        }   
      } 

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] string TagPlayer="Jugador";
    [SerializeField]int Points=10;

    void OnTriggerEnter(Collider other){
		if (other.tag == TagPlayer){
    Destroy (this.gameObject);
        GameManager.Points+=Points;
        Debug.Log(GameManager.Points);
        GameManager.Coins--;
        }
      } 

      void Awake(){
           GameManager.Coins++;   
      } 

}

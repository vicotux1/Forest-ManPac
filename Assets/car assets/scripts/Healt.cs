using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healt : MonoBehaviour
{
    [SerializeField] string TagPlayer="Jugador";
    [SerializeField] int Value=10;
    [SerializeField] bool IsEnemy=false;

    void OnTriggerEnter(Collider other){
		if (other.tag == TagPlayer){
      if(IsEnemy=false){
          Destroy (this.gameObject);
      }   
        GameManager.Hearts+=Value;
        Debug.Log(GameManager.Hearts);
        }
  } 
}

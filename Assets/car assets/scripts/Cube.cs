using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour{
    [SerializeField] string TagPlayer="Jugador";
    public GameObject Player;
    public Vector3 Destino;
    void Awake(){

        Player=GameObject.FindGameObjectWithTag(TagPlayer);  
      } 

    void OnTriggerEnter(Collider other){
		if (other.tag == TagPlayer){
        Player.transform.position=Destino;
        }
    } 
}

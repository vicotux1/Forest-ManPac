using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour{
    [SerializeField] string TagPlayer="Jugador";
    public GameObject Player;
    public Transform Destino;
    void Awake(){
        searchPlayer(); 
      }
      private void Update() {
         searchPlayer();
        
      } 

void searchPlayer(){
if (Player == null)
 Player=GameObject.FindGameObjectWithTag(TagPlayer);
} 
    void OnTriggerEnter(Collider other){
		if (other.tag == TagPlayer){
        Player.transform.position=Destino.transform.position+new Vector3(-1.0f, 0, -1.0f);
        }
    } 
}

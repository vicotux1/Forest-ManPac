using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadLimit : MonoBehaviour{
    
    [SerializeField]string TagJugador;

    void OnCollisionEnter(Collision other){
        if (other.transform.CompareTag(TagJugador)){
            GameManager.lives--;
        }
        
    }
   
}

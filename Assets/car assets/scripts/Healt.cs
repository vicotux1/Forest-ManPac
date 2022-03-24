using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healt : MonoBehaviour
{
    [SerializeField] string TagPlayer="Jugador";
    [SerializeField][Range(10,100)] int Value=10;
    [SerializeField][Range(1,2)]int SerialID=1;
    [SerializeField]GameManager GameManager;

    void Awake(){
      GameManager.Ejemplo+=140;
      Debug.Log("Ejemplo= "+ GameManager.Ejemplo);
    }
    
    void OnTriggerEnter(Collider other){
		if (other.tag == TagPlayer){
      if(SerialID==1){
          Destroy (this.gameObject);
           Debug.Log("sumaste vida");
           GameManager.Hearts+=Value;
           GameManager.Points+=(Value/2);
      }if (SerialID==2){
      GameManager.Hearts-=Value;
      GameManager.Points-=(Value/2);
      }   
        }
  } 
}

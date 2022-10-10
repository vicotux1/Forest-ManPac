using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healt : MonoBehaviour
{
    [SerializeField] string TagPlayer="Jugador";
    [SerializeField][Range(10,100)] int Value=10;

    [SerializeField]GameManager GameManager;
    [SerializeField] AudioSource audioSource;
    
    void Awake(){
      if(GameManager==null){
        GameManager=FindObjectOfType<GameManager>();
        Debug.Log(GameManager.Ejemplo);
        }
      }
    
    void OnTriggerEnter(Collider other){
		if (other.tag == TagPlayer){
          audioSource.Play();
         
           GameManager.Hearts+=Value;
           GameManager.Points+=(Value/2);
            Destroy (this.gameObject);
           
      }
  } 
}

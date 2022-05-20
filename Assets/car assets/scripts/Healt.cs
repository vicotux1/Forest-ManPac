using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healt : MonoBehaviour
{
    [SerializeField] string TagPlayer="Jugador";
    [SerializeField][Range(10,100)] int Value=10;
    [SerializeField][Range(1,2)]int SerialID=1;
    [SerializeField]bool IsCoin;

    [SerializeField]GameManager GameManager;
    void Update(){
      if(GameManager.Ejemplo==true){
       IsCoin=true;
      }else{
         IsCoin=false;
      }
    }
    void Awake(){
      if(GameManager==null){
        GameManager=FindObjectOfType<GameManager>();
        Debug.Log(GameManager.Ejemplo);
        }
      }
    
    void OnTriggerEnter(Collider other){
		if (other.tag == TagPlayer){
      if(SerialID==1){
          Destroy (this.gameObject);
           GameManager.Hearts+=Value;
           GameManager.Points+=(Value/2);
      }if (SerialID==2){
      GameManager.Hearts-=Value;
      GameManager.Points-=(Value/2);
      if (IsCoin==true){
        IsCoin=false;
        GameManager.Points+=Value;
        Destroy (this.gameObject);
        
        }
      }   
        }
  } 
}

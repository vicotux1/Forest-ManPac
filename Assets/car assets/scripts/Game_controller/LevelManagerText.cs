using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelManagerText: MonoBehaviour{
    public TextMeshProUGUI ganastes;
    public float waitTime=3;
    public string NextLevel, MainMenu="MainMenu";
    [SerializeField] GameManager gamanager;
    bool GameStart;
    
#region Funtion Unity

   void Update(){
       //ManagerUI.StartOtro();
       StartOtro();
      if ( gamanager.currentGameState==GameState.pause)
      {
          Debug.Log(gamanager.currentGameState);
          ganastes.text="el juego esta pausado";  
      }

    }
    void Start(){
        gamanager = FindObjectOfType<GameManager>();
        ganastes.text=" ";
        NextBola();
    }
#endregion

#region Funtion publics Creates

public void NextBola(){
    ganastes.text="lives:"+GameManager.lives.ToString();
        ganastes.text=" ";
    }
    public void ganaste(){
        ganastes.text="";
         gamanager.GameOver(NextLevel);
        /* if(NextLevel==MainMenu){
        Destroy(gamanager.gameObject, 0f);
         }*/
        
    }

    public void StartOtro(){
        if (GameManager.Coins==0 && GameStart== true){
            ganastes.text="No hay mas monedas";
            GameStart=false;
            Invoke ("ganaste" ,5f);       
        }if(GameManager.Coins!=0){
            GameStart=true;
            gamanager.StartGame();
            ganastes.text=""; 
        }
}  
    #endregion
}
    

 

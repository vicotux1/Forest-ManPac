using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelManagerText: MonoBehaviour{
    public TextMeshProUGUI ganastes;
    public float waitTime=3;
    private LevelManagerUI ManagerUI;
    [SerializeField] GameManager gamanager;
    bool GameStart;
    
#region Funtion Unity

   void Update(){
       //ManagerUI.StartOtro();
       StartOtro();
      

    }
    void Start(){
        ManagerUI=GetComponent<LevelManagerUI>();
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
         gamanager.GameOver();
    }

    public void StartOtro(){
        if (GameManager.Coins==0 && GameStart== true){
            ganastes.text="No hay mas monedas";
            GameStart=false;
            Invoke ("ganaste" ,5f);       
        }if(GameManager.Coins!=0){
            GameStart=true;
            gamanager.StartGame();
            Debug.Log("ya hay monedas");
              ganastes.text=""; 
        }
}  
    #endregion
}
    

 

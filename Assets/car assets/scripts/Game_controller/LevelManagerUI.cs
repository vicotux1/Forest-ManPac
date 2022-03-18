using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelManagerUI: MonoBehaviour{
    [Header("Game Datos")]
    [SerializeField]int Life;  
    [SerializeField] int Score=0, Heart=10, coins ;
    
    int lifeGameOver=0;
    [Header("textos")]
    [SerializeField]TextMeshProUGUI Points;

     [SerializeField]TextMeshProUGUI Lives,HeartText;
     [Header("Dependencias")]
     
     [SerializeField] LevelManagerText ManagerText;

    [SerializeField] GameManager gamanager;

    
#region Funtion Unity
    void Update(){
        Life=GameManager.lives;
        Score=GameManager.Points;
        Heart=GameManager.Hearts;
        coins=GameManager.Coins;
        Lives.text=Life.ToString();
        Points.text= Score.ToString();
        HeartText.text=Heart.ToString();
        LifeCoint();
       // StartOtro();
    }
    void Start(){
        Life=GameManager.lives;
        Lives.text=Life.ToString();
        Points.text= Score.ToString();
        //StartOtro();
    }
    public void StartOtro(){
        if (GameManager.Coins==0){
            gamanager.PauseGame();
            Debug.Log("no hay monedas");            
        }else{
            gamanager.StartGame();
            Debug.Log("ya hay monedas");  
    }
    }
#endregion

#region Funtion publics Creates
public void LifeCoint(){
        if(Life==lifeGameOver){
           // ManagerText.Perdiste();
       
        }else if(Life>=0){
         //StartCoroutine(NewBall(1.0f));   
        }
    }

#endregion


}  

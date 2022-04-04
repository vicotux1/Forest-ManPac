#region previous assignments
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#endregion
#region GameStates
public enum GameState{
    inGame, pause, gameOver
}
#endregion

public class GameManager : MonoBehaviour{
    
#region Asignaciones previas
    public static GameManager gameManager;
    public static GameManager GM_Lives;
    public static int lives=8,Points=0, Coins=0,Hearts=100;

    private int _Ejemplo=0;
    public int Ejemplo{
        get=>_Ejemplo;
        set=>_Ejemplo=value;
    }

    public static int HighScore;
    public string MainMenu="MainMenu";
    public GameState currentGameState;
    [SerializeField]private int Life,Healt, Colectables;
    
    public void HealtScore(){
     if (Hearts >= 300){
         Hearts=100;
        lives++;        
        }
    } 
    
#endregion

    void Awake() {
         Singleton();
    }
    void Update(){
        livesCount();
        UpdateInts();
        HeartsCount();
        HealtScore();
    }


#region metodos extras
    public void StartGame(){
        currentGameState=GameState.inGame;
        Time.timeScale = 1;
    }
    public void PauseGame(){
        currentGameState=GameState.pause;
        Time.timeScale = 0;
    }
    public void GameOver(string SceneToLoad){
        currentGameState=GameState.gameOver;
        Time.timeScale = 0;     
        
	   SceneManager.LoadScene (SceneToLoad);
       if(SceneToLoad==MainMenu){
           if(HighScore<=Points){
            HighScore=Points;
            Debug.Log("gameOver");
        }
           ResetGame();
       }
        
	}
    void ResetGame(){
        lives=8;
        Hearts=100;
        Points=0;
        Coins=0;     
        Time.timeScale = 1;
    }
    void NextLive(){    
        Time.timeScale = 1;
    }
    void livesCount(){
        if(lives==0){
            GameOver(MainMenu);
        }        
    }
    void HeartsCount(){
        if(Hearts<=0){
            lives-=1;
            Hearts=100;
            
           Time.timeScale = 0;
            Invoke("NextLive", 10f);
        }
    }
    void UpdateInts(){
        Life=lives;
        Healt=Hearts;
        
        
        Colectables=Coins;
    }
#endregion

#region singleton
        
    void Singleton(){
        if (gameManager!=null){
    Destroy(this.gameObject);      
    }else{ 
        gameManager=this;
    DontDestroyOnLoad(this.gameObject);
    }
        }


#endregion    
}    


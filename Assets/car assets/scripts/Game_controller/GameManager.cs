#region previous assignments
using System.Drawing;
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
    public static int lives=3;
    public static int Hearts=100;
    public static int Points=0;
    public static int Coins=0;
    public GameState currentGameState;
#endregion

#region metodos extras
    public void StartGame(){
        currentGameState=GameState.inGame;
        Time.timeScale = Time.timeScale == 0 ? 1: 0;
    }
    public void PauseGame(){
        currentGameState=GameState.pause;
        Time.timeScale = Time.timeScale == 0 ? 1: 0;
    }
    public void GameOver(){
        currentGameState=GameState.gameOver;
        Time.timeScale = 0; 
        Debug.Log("gameOver");
	SceneManager.LoadScene ("MainMenu");
    lives=3;
    Hearts=100;
    Points=0;
    Coins=0;
	}
#endregion

#region singleton
    void Awake() {
    Singleton();
    }
    
    
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


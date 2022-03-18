using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GMLives : MonoBehaviour{
    public static GMLives GM_Lives;
    public string main_Menu="00";
    public Destroy Destroy; 


   [Range (0, 9)] public int lives;
    public Text livesText;

    private void Awake() {  
    Texttostring() ;      
    if (GM_Lives!=null){
    Destroy(this.gameObject);      
    }else{GM_Lives=this;
    DontDestroyOnLoad(this.gameObject);
    Debug.Log("esto es un singleton lives");
        } 
    } 
    public void life(int count) {
    lives=lives+count;
    Texttostring();
    if (lives<=0){
        StartCoroutine(GamOver());
        }
    }
    
    void Texttostring() {
   livesText.text = lives.ToString();
    }
    public void GameOver(){
    StartCoroutine(GamOver());
}
    IEnumerator GamOver(){
        SceneManager.LoadScene (main_Menu);
        Time.timeScale = Time.timeScale == 0 ? 1: 0;
        Destroy(this.gameObject);
    yield return new WaitForSeconds(0);
    }
}

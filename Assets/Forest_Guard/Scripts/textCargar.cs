using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textCargar : MonoBehaviour
{
    public GameObject LoadText;
    void Start(){
    StartCoroutine (texCarga()); 
    }
    IEnumerator texCarga(){  
        LoadText.SetActive(true);                                                                                                                                                                                                     
    
    yield return new WaitForSeconds(5);
    LoadText.SetActive(false);
    }
    void Update(){
if (LoadText==null){
           LoadText=GameObject.Find("LoadText"); 
        }
    }
    void Awake(){
if (LoadText==null){
           LoadText=GameObject.Find("LoadText"); 
        }
    }
}

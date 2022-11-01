using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFXManagerv : MonoBehaviour{    
    
    [SerializeField]AudioSource audioSource;
    

    
    public void SoundPlay(AudioClip AudioPlay)
    {
        audioSource.clip=AudioPlay;
        audioSource.Play(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
